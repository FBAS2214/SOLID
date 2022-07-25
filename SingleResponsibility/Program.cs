namespace SingleResponsibility;

// SOLID Principles



// Bad Example

/*
public class SendEmail
{
    public bool Send(string mail, string message)
    {
        if (!IsMailAddressValid(mail))
        {
            return false;
        }


        // Send mail
        return true;
    }


    public bool IsMailAddressValid(string mail)
    {
        // check (Regex)
        return true;
    }
}
*/










// Good Example

public class MailAddressValidation
{
    public bool IsMailAddressValid(string mail)
    {
        // check (Regex)
        return true;
    }
}



public class SendEmail
{
    private MailAddressValidation _validation = new();
    public bool Send(string mail, string message)
    {
        if (!_validation.IsMailAddressValid(mail))
        {
            return false;
        }

        // Send mail
        return true;
    }
}