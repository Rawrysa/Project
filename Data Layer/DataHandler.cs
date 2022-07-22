using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace Project.DataLayer
{
    class DataHandler
    {
        private SqlConnection connection = new SqlConnection(@"Server= LAPTOP-MSQIEH6G\SQLEXPRESS; Initial Catalog= Premier Service Solutions; Integrated Security= SSPI");

        public DataTable ViewCalls()
        {
            DataTable tb = new DataTable();

            try
            {
                SqlDataAdapter adapter = new SqlDataAdapter("spViewCalls", connection);
                adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                DataTable table = new DataTable();
                adapter.Fill(table);
                tb = table;
            }
            catch
            {
                MessageBox.Show("Failed to get call log");
            }

            return tb;
        }

        public int NewCall(string CallDate, string CallDuration, string CallNumber, string ClientProblem, int ClientID)
        {
            int rows;

            try
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand("spNewCall", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@CallDate", CallDate);
                cmd.Parameters.AddWithValue("@CallDuration", CallDuration);
                cmd.Parameters.AddWithValue("@CallNumber", CallNumber);
                cmd.Parameters.AddWithValue("@ClientProblem", ClientProblem);
                cmd.Parameters.AddWithValue("@ClientID", ClientID);
                rows = cmd.ExecuteNonQuery();
                connection.Close();
            }
            catch
            {
                rows = 0;
            }

            return rows;
        }

        public DataTable ViewServices()
        {
            DataTable tb = new DataTable();

            try
            {
                SqlDataAdapter adapter = new SqlDataAdapter("spViewServices", connection);
                adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                DataTable table = new DataTable();
                adapter.Fill(table);
                tb = table;
            }
            catch
            {
                MessageBox.Show("Failed to get services");
            }

            return tb;
        }

        public DataTable ViewRequests()
        {
            DataTable tb = new DataTable();

            try
            {
                SqlDataAdapter adapter = new SqlDataAdapter("spViewRequests", connection);
                adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                DataTable table = new DataTable();
                adapter.Fill(table);
                tb = table;
            }
            catch
            {
                MessageBox.Show("Failed to get requests");
            }

            return tb;
        }

        public int NewRequest(int ClientID, int ServiceID)
        {
            int rows;

            try
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand("spNewRequest", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ClientID", ClientID);
                cmd.Parameters.AddWithValue("@ServiceID", ServiceID);
                rows = cmd.ExecuteNonQuery();
                connection.Close();
            }
            catch
            {
                rows = 0;
            }

            return rows;
        }

        public void RemoveRequest(int requestid)
        {
            try
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand("spRemoveRequest", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@RequestID", requestid);
                cmd.ExecuteNonQuery();
                connection.Close();

                MessageBox.Show($"{requestid} has been deleted");
            }
            catch
            {
                MessageBox.Show($"{requestid} could not be deleted");
            }

        }

        public DataTable ViewJobs()
        {
            DataTable tb = new DataTable();

            try
            {
                SqlDataAdapter adapter = new SqlDataAdapter("spViewJobs", connection);
                adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                DataTable table = new DataTable();
                adapter.Fill(table);
                tb = table;
            }
            catch
            {
                MessageBox.Show("Failed to get jobs");
            }

            return tb;
        }

        public int NewJob(string jobpriority, int technicianid, int ClientID, int ServiceID)
        {
            int rows;

            try
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand("spNewJob", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@JobPriority", jobpriority);
                cmd.Parameters.AddWithValue("@TechnicianID", technicianid);
                cmd.Parameters.AddWithValue("@ClientID", ClientID);
                cmd.Parameters.AddWithValue("@ServiceID", ServiceID);
                rows = cmd.ExecuteNonQuery();
                connection.Close();
            }
            catch
            {
                rows = 0;
            }

            return rows;
        }

        public void CloseJob(int jobid)
        {
            try
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand("spCloseJob", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@JobID", jobid);
                cmd.ExecuteNonQuery();
                connection.Close();

                MessageBox.Show($"{jobid} has been closed");
            }
            catch
            {
                MessageBox.Show($"{jobid} could not be closed");
            }

        }

        public DataTable TrackJob(int jobid)
        {
            DataTable table = new DataTable();

            try
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand("spTrackJob", connection);
                SqlDataAdapter dataAdapter = new SqlDataAdapter();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@JobID", jobid);
                SqlDataReader reader = cmd.ExecuteReader();
                DataTable tb = new DataTable();
                tb.Load(reader);
                table = tb;
                connection.Close();
            }
            catch
            {
                MessageBox.Show($"{jobid} could not be found");
            }

            return table;
        }

        public void EscalateJob(int jobid, string jobpriority)
        {
            try
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand("spEscalateJob", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@JobID", jobid);
                cmd.Parameters.AddWithValue("@JobPriority", jobpriority);
                cmd.ExecuteNonQuery();
                connection.Close();

                MessageBox.Show($"{jobid} has been escalated");
            }
            catch (Exception)
            {
                MessageBox.Show("Job could not be escalated");
            }
        }

        public void ReassignJob(int jobid, int technicianid)
        {
            try
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand("spReassignJob", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@JobID", jobid);
                cmd.Parameters.AddWithValue("@TechnicianID", technicianid);
                cmd.ExecuteNonQuery();
                connection.Close();

                MessageBox.Show($"{jobid} has been reassigned");
            }
            catch (Exception)
            {
                MessageBox.Show("Job could not be reassigned");
            }
        }

        public DataTable ViewClients()
        {
            DataTable tb = new DataTable();

            try
            {
                SqlDataAdapter adapter = new SqlDataAdapter("spViewClients", connection);
                adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                DataTable table = new DataTable();
                adapter.Fill(table);
                tb = table;
            }
            catch
            {
                MessageBox.Show("Failed to get clients");
            }

            return tb;
        }

        public int AddClient(string clientname, string clientsurname, string clientnumber, string clientaddress, string clienttype, int contractid)
        {
            int rows;

            try
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand("spAddClient", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ClientName", clientname);
                cmd.Parameters.AddWithValue("@ClientSurname", clientsurname);
                cmd.Parameters.AddWithValue("@ClientNumber", clientnumber);
                cmd.Parameters.AddWithValue("@ClientAddress", clientaddress);
                cmd.Parameters.AddWithValue("@ClientType", clienttype);
                cmd.Parameters.AddWithValue("@ContractID", contractid);
                rows = cmd.ExecuteNonQuery();
                connection.Close();
            }
            catch
            {
                rows = 0;
            }

            return rows;
        }

        public void DeleteClient(int clientid)
        {
            try
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand("spDeleteClient", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ClientID", clientid);
                cmd.ExecuteNonQuery();
                connection.Close();

                MessageBox.Show($"{clientid} has been removed");
            }
            catch
            {
                MessageBox.Show($"{clientid} could not be removed");
            }

        }

        public DataTable SearchClient(int clientid)
        {
            DataTable table = new DataTable();

            try
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand("spSearchClient", connection);
                SqlDataAdapter dataAdapter = new SqlDataAdapter();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ClientID", clientid);
                SqlDataReader reader = cmd.ExecuteReader();
                DataTable tb = new DataTable();
                tb.Load(reader);
                table = tb;
                connection.Close();
            }
            catch
            {
                MessageBox.Show($"{clientid} could not be found");
            }

            return table;
        }

        public void UpdateClient(int clientid, string clientname, string clientsurname, string clientnumber, string clientaddress, string clienttype, int contractid)
        {
            try
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand("spUpdateClient", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ClientID", clientid);
                cmd.Parameters.AddWithValue("@ClientName", clientname);
                cmd.Parameters.AddWithValue("@ClientSurname", clientsurname);
                cmd.Parameters.AddWithValue("@ClientNumber", clientnumber);
                cmd.Parameters.AddWithValue("@ClientAddress", clientaddress);
                cmd.Parameters.AddWithValue("@ClientType", clienttype);
                cmd.Parameters.AddWithValue("@ContractID", contractid);
                cmd.ExecuteNonQuery();
                connection.Close();

                MessageBox.Show($"{clientid} has been updated");
            }
            catch (Exception)
            {
                MessageBox.Show("Client could not be updated");
            }
        }

        public DataTable ClientAgreement(int clientid)
        {
            DataTable table = new DataTable();

            try
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand("spClientAgreement", connection);
                SqlDataAdapter dataAdapter = new SqlDataAdapter();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ClientID", clientid);
                SqlDataReader reader = cmd.ExecuteReader();
                DataTable tb = new DataTable();
                tb.Load(reader);
                table = tb;
                connection.Close();
            }
            catch
            {
                MessageBox.Show($"{clientid} could not be found");
            }

            return table;
        }

        public DataTable ViewContracts()
        {
            DataTable tb = new DataTable();

            try
            {
                SqlDataAdapter adapter = new SqlDataAdapter("spViewContracts", connection);
                adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                DataTable table = new DataTable();
                adapter.Fill(table);
                tb = table;
            }
            catch
            {
                MessageBox.Show("Failed to get contracts");
            }

            return tb;
        }

        public void ContractAvailability(int contractid, string availability)
        {
            try
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand("spContractAvailability", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ContractID", contractid);
                cmd.Parameters.AddWithValue("@Availability", availability);
                cmd.ExecuteNonQuery();
                connection.Close();

                MessageBox.Show($"{contractid} has been updated");
            }
            catch (Exception)
            {
                MessageBox.Show("Contract could not be updated");
            }
        }

        public DataTable ContractPerformance(int contractid)
        {
            DataTable table = new DataTable();

            try
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand("spContractPerformance", connection);
                SqlDataAdapter dataAdapter = new SqlDataAdapter();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ContractID", contractid);
                SqlDataReader reader = cmd.ExecuteReader();
                DataTable tb = new DataTable();
                tb.Load(reader);
                table = tb;
                connection.Close();
            }
            catch
            {
                MessageBox.Show($"{contractid} could not be found");
            }

            return table;
        }

        public int AddEmployee(int employeeid, int branchid)
        {
            int rows;

            try
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand("spAddEmployee", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@EmployeeID", employeeid);
                cmd.Parameters.AddWithValue("@BranchID", branchid);
                rows = cmd.ExecuteNonQuery();
                connection.Close();
            }
            catch
            {
                rows = 0;
            }

            return rows;
        }

        public void DeleteEmployee(int employeeid)
        {
            try
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand("spDeleteEmployee", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@EmployeeID", employeeid);
                cmd.ExecuteNonQuery();
                connection.Close();

                MessageBox.Show($"{employeeid} has been removed");
            }
            catch
            {
                MessageBox.Show($"{employeeid} could not be removed");
            }

        }

        public DataTable ViewAgents()
        {
            DataTable tb = new DataTable();

            try
            {
                SqlDataAdapter adapter = new SqlDataAdapter("spViewAgents", connection);
                adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                DataTable table = new DataTable();
                adapter.Fill(table);
                tb = table;
            }
            catch
            {
                MessageBox.Show("Failed to get call agents");
            }

            return tb;
        }

        public int AddAgent(string agentname, string agentsurname, string phonenumber, int agentid)
        {
            int rows;

            try
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand("spAddAgent", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@AgentName", agentname);
                cmd.Parameters.AddWithValue("@AgentSurname", agentsurname);
                cmd.Parameters.AddWithValue("@PhoneNumber", phonenumber);
                cmd.Parameters.AddWithValue("@AgentID", agentid);
                rows = cmd.ExecuteNonQuery();
                connection.Close();
            }
            catch
            {
                rows = 0;
            }

            return rows;
        }

        public DataTable SearchAgent(int agentid)
        {
            DataTable table = new DataTable();

            try
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand("spSearchAgent", connection);
                SqlDataAdapter dataAdapter = new SqlDataAdapter();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@AgentID", agentid);
                SqlDataReader reader = cmd.ExecuteReader();
                DataTable tb = new DataTable();
                tb.Load(reader);
                table = tb;
                connection.Close();
            }
            catch
            {
                MessageBox.Show($"{agentid} could not be found");
            }

            return table;
        }

        public void UpdateAgent(string agentname, string agentsurname, string phonenumber, int agentid)
        {
            try
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand("spUpdateAgent", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@AgentName", agentname);
                cmd.Parameters.AddWithValue("@AgentSurname", agentsurname);
                cmd.Parameters.AddWithValue("@PhoneNumber", phonenumber);
                cmd.Parameters.AddWithValue("@AgentID", agentid);
                cmd.ExecuteNonQuery();
                connection.Close();

                MessageBox.Show($"{agentid} has been updated");
            }
            catch (Exception)
            {
                MessageBox.Show("Agent could not be updated");
            }
        }

        public DataTable ViewTechnicians()
        {
            DataTable tb = new DataTable();

            try
            {
                SqlDataAdapter adapter = new SqlDataAdapter("spViewTechnicians", connection);
                adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                DataTable table = new DataTable();
                adapter.Fill(table);
                tb = table;
            }
            catch
            {
                MessageBox.Show("Failed to get technicians");
            }

            return tb;
        }

        public int AddTechnician(string technicianname, string techniciansurname, string phonenumber, string jobdescription, int technicianid)
        {
            int rows;

            try
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand("spAddTechnician", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@TechnicianName", technicianname);
                cmd.Parameters.AddWithValue("@TechnicianSurname", techniciansurname);
                cmd.Parameters.AddWithValue("@PhoneNumber", phonenumber);
                cmd.Parameters.AddWithValue("@JobDescription", jobdescription);
                cmd.Parameters.AddWithValue("@TechnicianID", technicianid);
                rows = cmd.ExecuteNonQuery();
                connection.Close();
            }
            catch
            {
                rows = 0;
            }

            return rows;
        }

        public DataTable SearchTechnician(int technicianid)
        {
            DataTable table = new DataTable();

            try
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand("spSearchTechnician", connection);
                SqlDataAdapter dataAdapter = new SqlDataAdapter();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@TechnicianID", technicianid);
                SqlDataReader reader = cmd.ExecuteReader();
                DataTable tb = new DataTable();
                tb.Load(reader);
                table = tb;
                connection.Close();
            }
            catch
            {
                MessageBox.Show($"{technicianid} could not be found");
            }

            return table;
        }

        public void UpdateTechnician(string technicianname, string techniciansurname, string phonenumber, string jobdescription, int technicianid)
        {
            try
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand("spUpdateTechnician", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@TechnicianName", technicianname);
                cmd.Parameters.AddWithValue("@TechnicianSurname", techniciansurname);
                cmd.Parameters.AddWithValue("@PhoneNumber", phonenumber);
                cmd.Parameters.AddWithValue("@JobDescription", jobdescription);
                cmd.Parameters.AddWithValue("@TechnicianID", technicianid);
                cmd.ExecuteNonQuery();
                connection.Close();

                MessageBox.Show($"{technicianid} has been updated");
            }
            catch (Exception)
            {
                MessageBox.Show("Technician could not be updated");
            }
        }

        public void TechnicianAvailability(int technicianid, string availability)
        {
            try
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand("spTechnicianAvailability", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@TechnicianID", technicianid);
                cmd.Parameters.AddWithValue("@Availability", availability);
                cmd.ExecuteNonQuery();
                connection.Close();

                MessageBox.Show($"{technicianid} has been assigned");
            }
            catch (Exception)
            {
                MessageBox.Show("Technician could not be updated");
            }
        }

        public DataTable ClientPriority(int clientid)
        {
            DataTable table = new DataTable();

            try
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand("spClientPriority", connection);
                SqlDataAdapter dataAdapter = new SqlDataAdapter();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ClientID", clientid);
                SqlDataReader reader = cmd.ExecuteReader();
                DataTable tb = new DataTable();
                tb.Load(reader);
                table = tb;
                connection.Close();
            }
            catch
            {
                MessageBox.Show($"{clientid} could not be found");
            }

            return table;
        }

        public DataTable ServiceLevel(int serviceid)
        {
            DataTable table = new DataTable();

            try
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand("spServiceLevel", connection);
                SqlDataAdapter dataAdapter = new SqlDataAdapter();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ServiceID", serviceid);
                SqlDataReader reader = cmd.ExecuteReader();
                DataTable tb = new DataTable();
                tb.Load(reader);
                table = tb;
                connection.Close();
            }
            catch
            {
                MessageBox.Show($"{serviceid} could not be found");
            }

            return table;
        }
    }
}
