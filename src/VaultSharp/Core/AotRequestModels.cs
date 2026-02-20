using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace VaultSharp.Core
{
    // Shape: { token }
    internal sealed class TokenRequest
    {
        [JsonPropertyName("token")]
        public string Token { get; set; }
    }

    // Shape: { token, client_id }
    internal sealed class TokenClientIdRequest
    {
        [JsonPropertyName("token")]
        public string Token { get; set; }

        [JsonPropertyName("client_id")]
        public string ClientId { get; set; }
    }

    // Shape: { input }
    internal sealed class InputRequest
    {
        [JsonPropertyName("input")]
        public string Input { get; set; }
    }

    // Shape: { path, token }
    internal sealed class PathTokenRequest
    {
        [JsonPropertyName("path")]
        public string Path { get; set; }

        [JsonPropertyName("token")]
        public string Token { get; set; }
    }

    // Shape: { path, accessor }
    internal sealed class PathAccessorRequest
    {
        [JsonPropertyName("path")]
        public string Path { get; set; }

        [JsonPropertyName("accessor")]
        public string Accessor { get; set; }
    }

    // Shape: { path }
    internal sealed class PathRequest
    {
        [JsonPropertyName("path")]
        public string Path { get; set; }
    }

    // Shape: { otp, pgpKey }  — note: the original anonymous type uses "pgpKey" as the C# property name, and STJ without custom naming policy serializes it as "pgpKey"
    internal sealed class OtpPgpKeyRequest
    {
        [JsonPropertyName("otp")]
        public string Otp { get; set; }

        [JsonPropertyName("pgpKey")]
        public string PgpKey { get; set; }
    }

    // Shape: { key, nonce } — used in root token generation AND rekey
    internal sealed class KeyNonceRequest
    {
        [JsonPropertyName("key")]
        public string Key { get; set; }

        [JsonPropertyName("nonce")]
        public string Nonce { get; set; }
    }

    // Shape: { value } — string value
    internal sealed class ValueRequest
    {
        [JsonPropertyName("value")]
        public string Value { get; set; }
    }

    // Shape: { secret_shares, secret_threshold, pgp_keys, backup }
    internal sealed class RekeyInitRequest
    {
        [JsonPropertyName("secret_shares")]
        public int SecretShares { get; set; }

        [JsonPropertyName("secret_threshold")]
        public int SecretThreshold { get; set; }

        [JsonPropertyName("pgp_keys")]
        public string[] PgpKeys { get; set; }

        [JsonPropertyName("backup")]
        public bool Backup { get; set; }
    }

    // Shape: { key, reset }
    internal sealed class KeyResetRequest
    {
        [JsonPropertyName("key")]
        public string Key { get; set; }

        [JsonPropertyName("reset")]
        public bool Reset { get; set; }
    }

    // Shape: { max_ttl }
    internal sealed class MaxTtlRequest
    {
        [JsonPropertyName("max_ttl")]
        public string MaxTtl { get; set; }
    }

    // Shape: { accessor }
    internal sealed class AccessorRequest
    {
        [JsonPropertyName("accessor")]
        public string Accessor { get; set; }
    }

    // Shape: { code }
    internal sealed class CodeRequest
    {
        [JsonPropertyName("code")]
        public string Code { get; set; }
    }

    // Shape: { ip, username }
    internal sealed class IpUsernameRequest
    {
        [JsonPropertyName("ip")]
        public string Ip { get; set; }

        [JsonPropertyName("username")]
        public string Username { get; set; }
    }

    // Shape: { serial_number }
    internal sealed class SerialNumberRequest
    {
        [JsonPropertyName("serial_number")]
        public string SerialNumber { get; set; }
    }

    // Shape: { cas } — used nested inside a dictionary
    internal sealed class CasRequest
    {
        [JsonPropertyName("cas")]
        public int Cas { get; set; }
    }

    // Shape: { versions }
    internal sealed class VersionsRequest
    {
        [JsonPropertyName("versions")]
        public System.Collections.Generic.IList<int> Versions { get; set; }
    }

    // Shape: { format } — used with KMIP CertificateFormat enum
    internal sealed class FormatRequest
    {
        [JsonPropertyName("format")]
        public string Format { get; set; }
    }

    // Shape: { ttl } — nullable long
    internal sealed class TtlRequest
    {
        [JsonPropertyName("ttl")]
        public long? Ttl { get; set; }
    }

    // Shape: { service_account_names }
    internal sealed class ServiceAccountNamesRequest
    {
        [JsonPropertyName("service_account_names")]
        public List<string> ServiceAccountNames { get; set; }
    }

    // Shape: { increment }
    internal sealed class IncrementRequest
    {
        [JsonPropertyName("increment")]
        public string Increment { get; set; }
    }

    // Shape: { policies } — string
    internal sealed class PoliciesRequest
    {
        [JsonPropertyName("policies")]
        public string Policies { get; set; }
    }

    // Shape: { policies, groups }
    internal sealed class PoliciesGroupsRequest
    {
        [JsonPropertyName("policies")]
        public string Policies { get; set; }

        [JsonPropertyName("groups")]
        public string Groups { get; set; }
    }

    // Shape: { name }
    internal sealed class NameRequest
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }
    }

    // Shape: { secret_id }
    internal sealed class SecretIdRequest
    {
        [JsonPropertyName("secret_id")]
        public string SecretId { get; set; }
    }

    // Shape: { secret_id_accessor }
    internal sealed class SecretIdAccessorRequest
    {
        [JsonPropertyName("secret_id_accessor")]
        public string SecretIdAccessor { get; set; }
    }

    // Shape: { secret_id_num_uses }
    internal sealed class SecretIdNumUsesRequest
    {
        [JsonPropertyName("secret_id_num_uses")]
        public long SecretIdNumUses { get; set; }
    }

    // Shape: { secret_id_ttl }
    internal sealed class SecretIdTtlRequest
    {
        [JsonPropertyName("secret_id_ttl")]
        public long SecretIdTtl { get; set; }
    }

    // Shape: { token_ttl }
    internal sealed class TokenTtlRequest
    {
        [JsonPropertyName("token_ttl")]
        public long TokenTtl { get; set; }
    }

    // Shape: { token_max_ttl }
    internal sealed class TokenMaxTtlRequest
    {
        [JsonPropertyName("token_max_ttl")]
        public long TokenMaxTtl { get; set; }
    }

    // Shape: { bind_secret_id }
    internal sealed class BindSecretIdRequest
    {
        [JsonPropertyName("bind_secret_id")]
        public bool BindSecretId { get; set; }
    }

    // Shape: { secret_id_bound_cidrs }
    internal sealed class SecretIdBoundCidrsRequest
    {
        [JsonPropertyName("secret_id_bound_cidrs")]
        public List<string> SecretIdBoundCidrs { get; set; }
    }

    // Shape: { token_bound_cidrs }
    internal sealed class TokenBoundCidrsRequest
    {
        [JsonPropertyName("token_bound_cidrs")]
        public List<string> TokenBoundCidrs { get; set; }
    }

    // Shape: { token_period }
    internal sealed class TokenPeriodRequest
    {
        [JsonPropertyName("token_period")]
        public long TokenPeriod { get; set; }
    }

    // Shape: { hmac }
    internal sealed class HmacRequest
    {
        [JsonPropertyName("hmac")]
        public bool Hmac { get; set; }
    }

    // Shape: { lease_id }
    internal sealed class LeaseIdRequest
    {
        [JsonPropertyName("lease_id")]
        public string LeaseId { get; set; }
    }

    // Shape: { lease_id, increment }
    internal sealed class LeaseRenewRequest
    {
        [JsonPropertyName("lease_id")]
        public string LeaseId { get; set; }

        [JsonPropertyName("increment")]
        public int Increment { get; set; }
    }

    // Shape: { level }
    internal sealed class LevelRequest
    {
        [JsonPropertyName("level")]
        public string Level { get; set; }
    }

    // Shape: { rules }
    internal sealed class RulesRequest
    {
        [JsonPropertyName("rules")]
        public string Rules { get; set; }
    }

    // Shape: { policy }
    internal sealed class PolicyTextRequest
    {
        [JsonPropertyName("policy")]
        public string Policy { get; set; }
    }

    // Shape: { role, cf_instance_cert, signing_time, signature } — for CloudFoundry login
    internal sealed class CloudFoundryLoginRequest
    {
        [JsonPropertyName("role")]
        public string Role { get; set; }

        [JsonPropertyName("cf_instance_cert")]
        public string CfInstanceCert { get; set; }

        [JsonPropertyName("signing_time")]
        public string SigningTime { get; set; }

        [JsonPropertyName("signature")]
        public string Signature { get; set; }
    }
}
