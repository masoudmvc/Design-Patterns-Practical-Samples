namespace ConsoleBeforeExam.Cases
{
    public class Encapsulation
    {
        #region Run
        //var encap = new Encapsulation();
        //encap.Add("masoud");
        //encap.Add("mona");

        //var list1 = encap.Data;
        //var list2 = encap.GetAll();

        //encap.Remove("masoud");

        //var list3 = encap.GetAll();
        #endregion

        private List<string> _data = new List<string>();

        public void Add(string param)
        {
            _data.Add(param);
        }

        public void Remove(string param)
        {
            //_data.Remove(param);
            _data.RemoveAll(x => x.Equals(param));
        }


        //public List<string> Data { get { return _data; } set { _data = value; } }
        public List<string> Data
        {
            get
            {
                // applying some bussinesses
                return _data;
            }
        }
        public List<string> GetAll()
        {
            // applying some bussinesses
            return _data;
        }
    }
}
