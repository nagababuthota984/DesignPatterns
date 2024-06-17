namespace DesignPatterns.Structural.Facade.Modules
{
    public class AuthenticationService
    {
        public bool IsAuthenticated()
        {
            return true;
        }

        public void PerformBiometricAuthentication()
        {
            Console.WriteLine("verifying your face...");
        }
        public void PerformPassCodeAuthentication()
        {
            Console.WriteLine("verifying the passcode...");
        }
    }
}
