




namespace Lab1Prog.Entities
{
    public class Job
    {
        public Job(string title, int payment)
        {
            this.title = title;
            this.payment = payment;
        }
        private string title;

        public string Title
        {
            get { return title; }
            set { title = value; }
        }

        private int payment;

        public int Payment
        {
            get { return payment; }
            set { payment = value; }
        }


    }
}
