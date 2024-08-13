using System.ComponentModel.DataAnnotations.Schema;

namespace ServerlessAPI.Models;

// Table や Column でアノテーションしないと DB のクエリがパスカルケースになり、
// スネークケースのテーブル・カラム名と異なりエラーになることを防ぐ
[Table("users")]
public class User
{
    [Column("id")]
    public Guid Id { get; set; } = Guid.Empty;
    [Column("account_name")]
    public required string AccountName { get; set; }
    [Column("password")]
    public required string Password { get; set; }
    [Column("name")]
    public required string Name { get; set; }
    [Column("created")]
    public DateTime Created { get; set; }
    [Column("modified")]
    public DateTime Modified { get; set; }
}