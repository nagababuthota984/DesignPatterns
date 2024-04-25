namespace DesignPatterns.Creational.Prototype.Models
{
    /// <summary>
    /// The Prototype interface, in most cases it contains a single clone method
    /// </summary>
    public interface ICloneable
    {
        object Clone();
    }
}
