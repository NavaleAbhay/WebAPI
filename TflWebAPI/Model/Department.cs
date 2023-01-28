using System.ComponentModel;
using Org.BouncyCastle.Utilities.Collections;

namespace TflWebAPI.Model;
public class Department{
    public int Id{get;set;}

    [DisplayName("Name")]
    public string Name{get;set;}

    [DisplayName("Location")]
    public string Location{get;set;}

}