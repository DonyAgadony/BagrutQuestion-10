class Patient
{
    public int id;
    public int priority { get; set; }
    public Patient(int id, int priority)
    {
        this.id = id;
        this.priority = priority;
    }
}
class PriorQueue(Queue<Patient> q)
{
    Queue<Patient> q = q;

    public void PriorInsert(Patient p)
    {
        Stack<Patient> temp = new();
        while (q.Peek().priority >= p.priority)
        {
            temp.Push(q.Dequeue());
        }
        q.Enqueue(p);
        while (temp.Count > 0)
        {
            q.Enqueue(temp.Pop());
        }
    }
    public void Update(int id, int pri)
    {
        Patient p = new(id, pri);
        PriorInsert(p);
        Stack<Patient> temp = new();
        while (q.Peek().id != id)
        {
            temp.Push(q.Dequeue());
        }
        q.Dequeue();
        while (temp.Count > 0)
        {
            q.Enqueue(temp.Pop());
        }
    }
}
class Program { }
