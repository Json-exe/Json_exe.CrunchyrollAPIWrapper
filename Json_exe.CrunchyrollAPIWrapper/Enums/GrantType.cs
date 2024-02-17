using System.Runtime.Serialization;

namespace Json_exe.CrunchyrollAPIWrapper.Enums;

public enum GrantType
{
    [EnumMember(Value = "client_id")]
    ClientId,
    [EnumMember(Value = "password")]
    Password,
    [EnumMember(Value = "etp_rt_token")]
    EtpRtToken,
    [EnumMember(Value = "refresh_token")]
    RefreshToken
}