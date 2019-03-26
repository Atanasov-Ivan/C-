using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    class ConnectToDB
    {

        OleDbConnection connection;
        OleDbCommand command;
        private void ConnectTo()
        {
            connection = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\student\Desktop\newest\Data123 - Copy.accdb");
            command = connection.CreateCommand();
        }
        public ConnectToDB()
        {
            ConnectTo();
        }

        public void InsertWC(WorkingCart123 p)
        {
            try
            {
                command.CommandText = "INSERT INTO Workingcard(id_WorkingCard, [Begin], [End], WorkingTask, [Status], [Taskdescription], [Username]) VALUES ("
                +
               
                 p.id_WorkingCart   +"," + "'" + p.begin + "'" + "," + "'" + p.end + "'" + ","  + p.taskName + "," +
               "'"                + p.status + "'" + "," + "'" + p.description + "'" + "," +"'" +p.username + "')";
                command.CommandType = CommandType.Text;
                connection.Open();
                command.ExecuteNonQuery();
            }
            catch (Exception)
            {
                //throw;
                MessageBox.Show("Некоректни данни! Моля въведете отново!");
            }
            finally
            {
                if (connection != null)
                {
                    connection.Close();
                }
            }

        }

        public void UpdateWC(WorkingCart123 p)
        {
            try
            {
                //command.CommandText = "UPDATE Employee SET Username='" + p.Username + "," + " Password=" + p.Password + "," + " FirstName=" + "'" + p.FirstName + "," + " LastName=" + "'" + p.LastName + "," + " Position=" + "'" + p.Position + "," + " Lastaction=" + "'" + p.Lastaction + "'" + " WHERE Username=" + p.Username;
                command.CommandType = CommandType.Text;
                connection.Open();
                command.ExecuteNonQuery();
            }
            catch (Exception)
            {
                //throw;
                MessageBox.Show("Некоректни данни! Моля въведете отново!");
            }
            finally
            {
                if (connection != null)
                {
                    connection.Close();
                }
            }

        }

        public void Insert(Data123 p)
        {
            try
            {
                command.CommandText = "INSERT INTO Employee([Username], [Password], [FirstName], [LastName], [Position], [Lastaction]) VALUES ("
                    //"'1','2', '1', '1','1', '1')";
                    + "'" + p.Username + "', '" + p.Password + "' , '" + p.FirstName + "', '" + p.LastName + "', '" + p.Position + "', '" + p.Lastaction + "')";
                command.CommandType = CommandType.Text;
                connection.Open();
                command.ExecuteNonQuery();
            }
            catch (Exception)
            {
                //throw;
                MessageBox.Show("Некоректни данни! Моля въведете отново!");
            }
            finally
            {
                if (connection != null)
                {
                    connection.Close();
                }
            }

        }

       

        // UPDATE

        public void Update(Data123 p)
        {
            try
            {
                command.CommandText = "UPDATE Employee SET Username='" + p.Username + "," + " Password=" + p.Password + "," + " FirstName=" + "'" + p.FirstName + "," + " LastName=" + "'" + p.LastName + "," + " Position=" + "'" + p.Position + "," + " Lastaction=" + "'" + p.Lastaction +"'" + " WHERE Username=" + p.Username;
               // command.CommandText = "UPDATE Employee SET Username =  WHERE id = ?";
                  command.CommandType = CommandType.Text;
                connection.Open();
                command.ExecuteNonQuery();
            }
            catch (Exception)
            {
                //throw;
                MessageBox.Show("Некоректни данни! Моля въведете отново!");
            }
            finally
            {
                if (connection != null)
                {
                    connection.Close();
                }
            }
        }
         
        }
    }

