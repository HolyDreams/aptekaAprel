using NpgsqlTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using System.Data;

namespace aptekaAprel
{
    internal class Query : IDisposable
    {
        string connect;
        NpgsqlParameter parameter;
        NpgsqlConnection con;
        NpgsqlCommand command;
        NpgsqlTransaction transaction;
        string sqlQuery;
        public Query()
        {
            connect = $@"Host=77.222.53.3;
                         Username=holy_admin;
                         Password=Riff1199;
                         Port=5100;
                         Database=postgres";
            command = new NpgsqlCommand();
            if (!OpenConnection())
                return;

            sqlQuery = "SELECT * FROM hsbg_eu_changes";
        }
        bool DeriveParameters()
        {
            if (command != null &&  command.CommandType == CommandType.StoredProcedure)
            {
                NpgsqlCommandBuilder.DeriveParameters(command);
                return true;
            }
            else
                return false;
        }
        bool OpenConnection()
        {
            try
            {
                con = new NpgsqlConnection(connect);
                con.Open();
                command.Connection = con;
                return true;
            }
            catch (Exception ex) 
            { 
                return false;
            }
        }
        bool CloseConnection()
        {
            try
            {
                con.Close();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        bool Add(string parameterName, object parameterValue, NpgsqlDbType type)
        {
            try
            {
                parameter = new NpgsqlParameter(parameterName, type);
                parameter.Value = parameterValue;
                command.Parameters.Add(parameter);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        bool ExecuteNonQuery()
        {
            try
            {
                command.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        bool RollBackTransaction()
        {
            try
            {
                transaction.Rollback();
                return true;
            }
            catch (Exception ex) 
            {
                return false;
            }
        }
        bool CommitTransaction()
        {
            try
            {
                transaction.Commit();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public DataTable FillData(string addPar = null)
        {
            try
            {
                command.CommandText = sqlQuery + Environment.NewLine + addPar;
                var adapter = new NpgsqlDataAdapter(command);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                return dt;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        public void Dispose()
        {
            CloseConnection();
            con.Dispose();
        }
    }
}