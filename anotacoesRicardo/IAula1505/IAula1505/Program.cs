namespace IAula1505
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bem vindo!");
            IMotor motor;

            MotorEletrico me = new MotorEletrico();

            Console.WriteLine("Digite 1 para ligar o motor elétrico e 2 para ligar o motor a combustão: ");
            int op = int.Parse(Console.ReadLine());
            if (op == 1)
            {
                motor = new MotorEletrico();
                motor.Ligar();

                motor.Deligar();
            }
            else if (op == 2)
            {
                motor = new MotorCombustao();
                motor.Ligar();
                motor.Deligar();
            }
            

        }
    }
}