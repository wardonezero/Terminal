//Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=ADONETEXAMPLEDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False
using static System.Console;
using Microsoft.Data.SqlClient;
using System.Data;

string ConString = "Data Source=(localdb)\\MSSQLLocalDB;" +
                   "Initial Catalog=ADONETEXAMPLEDB;" +
                   "Integrated Security=True;" +
                   "Connect Timeout=30;" +
                   "Encrypt=False;" +
                   "Trust Server Certificate=False;" +
                   "Application Intent=ReadWrite;" +
                   "Multi Subnet Failover=False";
SqlConnection con = new(ConString);
string querystring = "SELECT * FROM Student";
con.Open();
SqlCommand cmd = new(querystring, con);
SqlDataReader reader = cmd.ExecuteReader();
while (reader.Read())
{
    WriteLine(reader[0].ToString() + " " + reader[1].ToString() + " " + reader[2].ToString());
}
con.Close();
con.Dispose();