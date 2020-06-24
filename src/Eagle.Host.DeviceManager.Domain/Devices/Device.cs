using JetBrains.Annotations;
using System;
using Volo.Abp;
using Volo.Abp.Domain.Entities.Auditing;
using Volo.Abp.MultiTenancy;

namespace Eagle.Host.DeviceManager.Devices
{
    // and this
    public class Device : FullAuditedAggregateRoot<Guid>, IMultiTenant
    {


        public virtual Guid? TenantId { get; set; }

        public virtual int Number { get; set; }

        [NotNull]
        public virtual string Name { get; set; }



        public Device()
        {

        }

        public Device(Guid id, int number, string name)
        {
            Id = id;
            Check.NotNull(name, nameof(name));
            Check.Length(name, nameof(name), DeviceConsts.NameMaxLength, 0);
            Number = number;
            Name = name;

        }
    }
}