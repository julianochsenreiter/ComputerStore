using ComputerStore;
using System;
using System.Collections.Generic;

public abstract class PCBuilder
{
    protected bool optimizePerformance;
    protected ComputerCase @case;
    protected CPU cpu;
    protected MainMemory ram;
    protected List<Harddisk> disks;
    protected GraphicsCard graphicsCard;
    protected decimal price;
    protected PCBuilder(bool optimizePerformance)
    {
        this.optimizePerformance = optimizePerformance;
        disks = new List<Harddisk>();
    }
    public abstract PCBuilder AddCase();
    public abstract PCBuilder AddCPU();
    public abstract PCBuilder AddRAM();
    public abstract PCBuilder AddDisks();
    public abstract PCBuilder AddGraphicsCard();
    public abstract PCBuilder SetPrice();
    public PC Build()
    {
        if (@case == null || cpu == null || ram == null || disks.Count == 0 || graphicsCard == null)
            throw new InvalidOperationException("System is not ready to be built.");
        return new PC(@case, cpu, ram, disks.ToArray(), graphicsCard, price);
    }
}