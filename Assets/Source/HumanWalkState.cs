public class HumanWalkState : IState
{
    public HumanWalkState()
    {

    }
    public IState NextState()
    {
        return this;
    }
}