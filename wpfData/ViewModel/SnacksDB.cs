using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;


namespace ViewModel
{
    public class SnacksDB:BaseDB
    {
        protected override BaseEntity NewEntity()
        {
            return new Snacks() as BaseEntity; //יצירת עצם חדש מסוג
        }

        //Reader-מילוי העצם בערכים מה
        protected override BaseEntity CreateModel(BaseEntity entity)
        {
            Snacks Snacks = (Snacks)entity;
            Snacks.Id = (int)this.reader["ID"];
            Snacks.SnacksName = (string)this.reader["NameSnack"];
            return Snacks;
        }

        public SnacksList SelectbyUser(User user)
        {
            command.CommandText = $"SELECT * FROM (Tbsnacks INNER JOIN Idsnacks ON Tbsnacks.ID = Idsnacks.IDsancks) WHERE IDuser={user.Id}";
            SnacksList list = new SnacksList(base.ExecuteCommand());
            return list;
        }

        public SnacksList SelectById(int id)
        {
            command.CommandText = string.Format($"SELECT * FROM Tbsnacks WHERE ID={id}");
            SnacksList List = new SnacksList(base.ExecuteCommand());
            if (List.Count == 0)
                return null;
            return List;
        }
    }
}
