namespace OCPLibrary
{
    interface IApplicantModel
    {
        string FirstName { get; set; }
        string LastName { get; set; }
        IAccounts AccountProccessor { get; set; }
    }
}