namespace DGX.Action
{
    public interface IStateMachine
    {
        void HandleUpdate();

        /// <summary>
        /// Message from external manager
        /// </summary>
        /// <param name="message"></param>
        void OnMessage(string message);

        /// <summary>
        /// when new action start
        /// </summary>
        /// <param name="id"></param>
        void OnNewAction(int id);
    }
}
