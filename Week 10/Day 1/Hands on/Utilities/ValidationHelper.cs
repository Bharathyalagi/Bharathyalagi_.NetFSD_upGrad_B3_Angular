using ContactManagement.Models;

namespace ContactManagement.Utilities
{
    public static class ValidationHelper
    {
        public static void ValidateContact(Contact contact)
        {
            if (string.IsNullOrWhiteSpace(contact.Name))
                throw new ArgumentException("Name is required");

            if (!contact.Email.Contains("@"))
                throw new ArgumentException("Invalid email");

            if (contact.Phone.Length < 10)
                throw new ArgumentException("Invalid phone number");
        }
    }
}