using System.Text.Json.Serialization;

namespace Core.Models.Cases;

public class CasesListView
{
    public int Id { get; set; }
    [JsonPropertyName("Creado el")]
    public string CreatedAt { get; set; }
    [JsonPropertyName("Nro de Ticket")]
    public string TicketNumber { get; set; }
    [JsonPropertyName("Tipo")]
    public string TypeName { get; set; }
    [JsonPropertyName("Subtipo")]
    public string SubtypeName { get; set; }
    [JsonPropertyName("Tipificación")]
    public string TypificationName  { get; set; }
    [JsonPropertyName("Sucursal Recepcion")]
    public string ReceptionBranch  { get; set; }
    [JsonPropertyName("Recepcionado el")]
    public string ReceptionTime  { get; set; }
    [JsonPropertyName("Sucursal Afectada")]
    public string BranchAffected  { get; set; }
    [JsonPropertyName("Estado")]
    public string CaseStatusName  { get; set; }
    [JsonPropertyName("Origen")]
    public string OriginName  { get; set; }
    [JsonPropertyName("Subject")]
    public string Subject  { get; set; }
    [JsonPropertyName("Descripción")]
    public string Description  { get; set; }
    [JsonPropertyName("Dueño del caso")]
    public string CaseOwnerName  { get; set; }
    [JsonPropertyName("Areas Resolutoras")]
    public List<string> ResolverAreas  { get; set; }
    [JsonPropertyName("Empresa")]
    public string CompanyName  { get; set; }
    [JsonPropertyName("Direccion de llamada")]
    public string CallDirection  { get; set; }
    [JsonPropertyName("Tags")]
    public List<string> Tags  { get; set; }
    [JsonPropertyName("Actualizado ")]
    public string UpdatedAt  { get; set; }
    [JsonPropertyName("Solución")]
    public string Solution  { get; set; }
    [JsonPropertyName("Comentario")]
    public string Comment  { get; set; }
    [JsonPropertyName("Pedido de Extensión")]
    public string RequestExtension  { get; set; }
    [JsonPropertyName("Oficial de Negocios")]
    public string BusinessOfficer  { get; set; }
    [JsonPropertyName("Promotor")]
    public string Promoter { get; set; }
    [JsonPropertyName("Numero de Comentarios")]
    public int NumberOfComments { get; set; }
    [JsonPropertyName("Contacto")]
    public string ContactName { get; set; }
    [JsonPropertyName("Contacto de Email")]
    public string ContactEmail { get; set; }
    [JsonPropertyName("Nro de Cliente")]
    public string ClientNumber { get; set; }
    [JsonPropertyName("Nro de Teléfono")]
    public string ContactPhone { get; set; }
    [JsonPropertyName("Contacto Full Name")]
    public string ContactFullName { get; set; }
    [JsonPropertyName("Sucursal Cliente")]
    public string ClientBranch { get; set; }
    [JsonPropertyName("Layout")]
    public string Layout { get; set; }

}