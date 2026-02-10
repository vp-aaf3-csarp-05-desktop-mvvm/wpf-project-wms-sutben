namespace WMSProject
{
    /// <summary>
    /// Dolgozó adatok megjelenítéshez (szabadnapkezelés) 
    /// </summary>
    public class EmployeeViewModel
    {
        /// <summary>
        /// Dolgozó neve
        /// </summary>
        public string Name { get; } = "Nagy Anna";

        /// <summary>
        /// Adószáma
        /// </summary>
        public string TaxNum { get; } = "12345678 - 2 - 10";

        /// <summary>
        /// Kivett szabadnapok száma
        /// </summary>
        public int DaysOff { get; } = 6;
    }
}
