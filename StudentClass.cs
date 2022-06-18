using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;


namespace CourseManagementSytem
{
    internal class StudentClass
    {
        DBconnect connect = new DBconnect();
        //create a function to add a new students to the database

        public bool insertStudent(string name, string sname, string gender, string mail)
        {
            MySqlCommand command = new MySqlCommand("INSERT INTO `student`(`StudentName`, `StudentSurname`, `Gender`, `StudentMail`) VALUES(@n, @sn, @g, @m)", connect.getconnection);

            //@fn, @ln, @bd, @gd, @ph, @adr, @img
            command.Parameters.Add("@n", MySqlDbType.VarChar).Value = name;
            command.Parameters.Add("@sn", MySqlDbType.VarChar).Value = sname;
            command.Parameters.Add("@gd", MySqlDbType.VarChar).Value = gender;
            command.Parameters.Add("@m", MySqlDbType.VarChar).Value = mail;

            connect.openConnect();
            if (command.ExecuteNonQuery() == 1)
            {
                connect.closeConnect();
                return true;
            }
            else
            {
                connect.closeConnect();
                return false;
            }
        }
    }
}
