using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace week11
{
    class KetNoi
    {
        public SqlConnection connect;
        private static string Database = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\LuuDuLieuSinhVien\.ahihi\week11\week11\week11.mdf;Integrated Security=True";
        public KetNoi()
        {
            connect = new SqlConnection(@"Data Source=(LocalDB)