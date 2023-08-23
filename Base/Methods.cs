using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.Control;
using AngleSharp.Dom;

namespace aptekaAprel
{
    internal class Methods
    {
        static Guid ID = Guid.Empty;
        public static List<Columns> ReadFavs()
        {
            if (!File.Exists("favs.json"))
                return null;

            var jsonString = File.ReadAllText("favs.json");
            var json = JsonSerializer.Deserialize<Favorites>(jsonString);
            var columns = new List<Columns>();
            ID = json.ID;
            foreach (Columns item in json.Col)
            {
                columns.Add(new Columns()
                {
                    Name = item.Name,
                    Index = item.Index,
                    Width = item.Width,
                    Visible = item.Visible
                });
            }    
            return columns;
        }
        public static void WriteFavs(List<Columns> cols)
        {
            if (ID == Guid.Empty)
                ID = Guid.NewGuid();

            var Favs = new Favorites()
            {
                ID = ID,
                Col = cols
            };
            var json = JsonSerializer.Serialize(Favs);
            File.WriteAllText("favs.json", json);
        }
        public static bool DataCheck(ControlCollection controls)
        {
            foreach (Control control in controls)
            {
                Type type = control.GetType().GetInterface("ICheckableControl");
                if (type == typeof(ICheckableControl) && ((ICheckableControl)control).EmptyDataCheck && !((ICheckableControl)control).Check())
                    return false;
            }
            return true;
        }
        public static bool CreateScreenShot()
        {
            try
            {
                var screens = Screen.AllScreens;
                int width = 0;
                int height = 0;
                foreach (var screen in screens)
                {
                    width += screen.Bounds.Width;
                    if (screen.Bounds.Height > height)
                        height = screen.Bounds.Height;
                }
                Bitmap captureBitmap = new Bitmap(width, height, PixelFormat.Format32bppArgb);

                Graphics captureGraphics = Graphics.FromImage(captureBitmap);

                captureGraphics.CopyFromScreen(0, 0, 0, 0, new Size(width, height));

                captureBitmap.Save($@"screenshot.png", ImageFormat.Png);

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
        public static string LastVersionNet()
        {
            string maxDotNetVersion = GetVersionFromRegistry();
            if (String.Compare(maxDotNetVersion, "4.5") >= 0)
            {
                string v45Plus = Get45PlusFromRegistry();
                if (v45Plus != "") maxDotNetVersion = v45Plus;
            }
            return maxDotNetVersion;
        }
        private static string Get45PlusFromRegistry()
        {
            String dotNetVersion = "";
            const string subkey = @"SOFTWARE\Microsoft\NET Framework Setup\NDP\v4\Full\";
            using (RegistryKey ndpKey = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry32).OpenSubKey(subkey))
            {
                if (ndpKey != null && ndpKey.GetValue("Release") != null)
                {
                    dotNetVersion = CheckFor45PlusVersion((int)ndpKey.GetValue("Release"));
                    Console.WriteLine(".NET Framework Version: " + dotNetVersion);
                }
                else
                {
                    Console.WriteLine(".NET Framework Version 4.5 or later is not detected.");
                }
            }
            return dotNetVersion;
        }

        // Checking the version using >= will enable forward compatibility.
        private static string CheckFor45PlusVersion(int releaseKey)
        {
            if (releaseKey >= 528040) return "4.8 or later";
            if (releaseKey >= 461808) return "4.7.2";
            if (releaseKey >= 461308) return "4.7.1";
            if (releaseKey >= 460798) return "4.7";
            if (releaseKey >= 394802) return "4.6.2";
            if (releaseKey >= 394254) return "4.6.1";
            if (releaseKey >= 393295) return "4.6";
            if ((releaseKey >= 379893)) return "4.5.2";
            if ((releaseKey >= 378675)) return "4.5.1";
            if ((releaseKey >= 378389)) return "4.5";

            // This code should never execute. A non-null release key should mean
            // that 4.5 or later is installed.
            return "No 4.5 or later version detected";
        }

        private static string GetVersionFromRegistry()
        {
            String maxDotNetVersion = "";
            // Opens the registry key for the .NET Framework entry.
            using (RegistryKey ndpKey = RegistryKey.OpenRemoteBaseKey(RegistryHive.LocalMachine, "")
                                            .OpenSubKey(@"SOFTWARE\Microsoft\NET Framework Setup\NDP\"))
            {
                // As an alternative, if you know the computers you will query are running .NET Framework 4.5 
                // or later, you can use:
                // using (RegistryKey ndpKey = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, 
                // RegistryView.Registry32).OpenSubKey(@"SOFTWARE\Microsoft\NET Framework Setup\NDP\"))
                foreach (string versionKeyName in ndpKey.GetSubKeyNames())
                {
                    if (versionKeyName.StartsWith("v"))
                    {
                        RegistryKey versionKey = ndpKey.OpenSubKey(versionKeyName);
                        string name = (string)versionKey.GetValue("Version", "");
                        string sp = versionKey.GetValue("SP", "").ToString();
                        string install = versionKey.GetValue("Install", "").ToString();
                        if (install == "") //no install info, must be later.
                        {
                            Console.WriteLine(versionKeyName + "  " + name);
                            if (String.Compare(maxDotNetVersion, name) < 0) maxDotNetVersion = name;
                        }
                        else
                        {
                            if (sp != "" && install == "1")
                            {
                                Console.WriteLine(versionKeyName + "  " + name + "  SP" + sp);
                                if (String.Compare(maxDotNetVersion, name) < 0) maxDotNetVersion = name;
                            }

                        }
                        if (name != "")
                        {
                            continue;
                        }
                        foreach (string subKeyName in versionKey.GetSubKeyNames())
                        {
                            RegistryKey subKey = versionKey.OpenSubKey(subKeyName);
                            name = (string)subKey.GetValue("Version", "");
                            if (name != "")
                            {
                                sp = subKey.GetValue("SP", "").ToString();
                            }
                            install = subKey.GetValue("Install", "").ToString();
                            if (install == "")
                            {
                                //no install info, must be later.
                                Console.WriteLine(versionKeyName + "  " + name);
                                if (String.Compare(maxDotNetVersion, name) < 0) maxDotNetVersion = name;
                            }
                            else
                            {
                                if (sp != "" && install == "1")
                                {
                                    Console.WriteLine("  " + subKeyName + "  " + name + "  SP" + sp);
                                    if (String.Compare(maxDotNetVersion, name) < 0) maxDotNetVersion = name;
                                }
                                else if (install == "1")
                                {
                                    Console.WriteLine("  " + subKeyName + "  " + name);
                                    if (String.Compare(maxDotNetVersion, name) < 0) maxDotNetVersion = name;
                                } // if
                            } // if
                        } // for
                    } // if
                } // foreach
            } // using
            return maxDotNetVersion;
        }
    }
}
