public class GuestGroup
{
    private int groupSize;
    private int days;

    public int GroupSize
    {
        get { return groupSize; }
        set { groupSize = value; }
    }

    public int Days
    {
        get { return groupSize; }
        set { days = value; }
    }

    public GuestGroup(int size, int days)
    {
        this.GroupSize = size;
        this.Days = days;
    }
}