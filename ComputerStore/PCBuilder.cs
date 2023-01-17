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
    public abstract void AddCase();
    public abstract void AddCPU();
    public abstract void AddRAM();
    public abstract void AddDisks();
    public abstract void AddGraphicsCard();
    public abstract void SetPrice();
    public PC Build()
    {
        if (@case == null || cpu == null || ram == null || disks.Count == 0 || graphicsCard == null)
            throw new InvalidOperationException("System is not ready to be built.");
        return new PC(@case, cpu, ram, disks.ToArray(), graphicsCard, price);
    }
}