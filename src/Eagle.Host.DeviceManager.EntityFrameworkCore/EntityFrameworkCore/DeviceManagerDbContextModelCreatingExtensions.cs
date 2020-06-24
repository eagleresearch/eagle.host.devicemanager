using Eagle.Host.DeviceManager.Devices;
using Microsoft.EntityFrameworkCore;
using System;
using Volo.Abp;
using Volo.Abp.EntityFrameworkCore.Modeling;

namespace Eagle.Host.DeviceManager.EntityFrameworkCore
{
    public static class DeviceManagerDbContextModelCreatingExtensions
    {
        public static void ConfigureDeviceManager(
            this ModelBuilder builder,
            Action<DeviceManagerModelBuilderConfigurationOptions> optionsAction = null)
        {
            Check.NotNull(builder, nameof(builder));

            var options = new DeviceManagerModelBuilderConfigurationOptions(
                DeviceManagerDbProperties.DbTablePrefix,
                DeviceManagerDbProperties.DbSchema
            );

            optionsAction?.Invoke(options);

            /* Configure all entities here. */

            builder.Entity<Device>(b =>
            {
                //Configure table & schema name
                b.ToTable(options.TablePrefix + "Devices", options.Schema);

                b.ConfigureByConvention();

                //Properties
                b.Property(d => d.Number).IsRequired();
                b.Property(d => d.Name).IsRequired().HasMaxLength(DeviceConsts.NameMaxLength);

                //Relations
                //b.HasMany(d => d.Tags).WithOne().HasForeignKey(dt => dt.QuestionId);

                //Indexes
                b.HasIndex(d => new { d.TenantId, d.Number });
            });
        }
    }
}