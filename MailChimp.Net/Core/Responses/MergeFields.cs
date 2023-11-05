using Newtonsoft.Json;

namespace MailChimp.Net.Core.Responses;

public class MergeFields
{
    [JsonProperty("FNAME")]
    public string FirstName { get; set; }

    [JsonProperty("LNAME")]
    public string LastName { get; set; }

    [JsonProperty("ADDRESS")]
    public MergeFieldAddress Address { get; set; }

    [JsonProperty("PHONE")]
    public string Phone { get; set; }
}


public class MergeFieldAddress
{
    /// <summary>
    /// Gets or sets the address 1.
    /// </summary>
    [JsonProperty("addr1")]
    public string Address1 { get; set; }

    /// <summary>
    /// Gets or sets the address 2.
    /// </summary>
    [JsonProperty("addr1")]
    public string Address2 { get; set; }

    /// <summary>
    /// Gets or sets the city.
    /// </summary>
    [JsonProperty("city")]
    public string City { get; set; }

    /// <summary>
    /// Gets or sets the country.
    /// </summary>
    [JsonProperty("country")]
    public string Country { get; set; }

    /// <summary>
    /// Gets or sets the postal code.
    /// </summary>
    [JsonProperty("zip")]
    public string ZipCode { get; set; }

    /// <summary>
    /// Gets or sets the province.
    /// </summary>
    [JsonProperty("state")]
    public string State { get; set; }

}