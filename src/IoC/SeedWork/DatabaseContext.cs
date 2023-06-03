// Copyright (c) Bruno Sales <me@baliestri.dev>. Licensed under the MIT License.
// See the LICENSE file in the repository root for full license text.

using ASPNETCoreTemplate.Core.Entities.Users;
using ASPNETCoreTemplate.IoC.Abstractions.SeedWork;
using ASPNETCoreTemplate.IoC.SeedWork.Conventions;
using Microsoft.EntityFrameworkCore;

namespace ASPNETCoreTemplate.IoC.SeedWork;

/// <summary>
///   Database context.
/// </summary>
public sealed class DatabaseContext : DbContext, IDatabaseContext {
  /// <summary>
  ///   Initializes a new instance of the <see cref="DatabaseContext" /> class.
  /// </summary>
  /// <param name="options">The options.</param>
  public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options) { }

  #region Entities

  public DbSet<User> Users { get; set; } = default!;

  #endregion

  /// <inheritdoc />
  protected override void OnModelCreating(ModelBuilder modelBuilder)
    => modelBuilder.ApplyConfigurationsFromAssembly(typeof(DatabaseContext).Assembly);

  /// <inheritdoc />
  protected override void ConfigureConventions(ModelConfigurationBuilder configurationBuilder)
    => configurationBuilder.Conventions.Add(_ => new SnakeCaseConvention());
}
