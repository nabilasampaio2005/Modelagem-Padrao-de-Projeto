namespace CommandSolucao.Commands
{
    public interface Command
    {
        public void executar();
        public void desfazer();
    }
}