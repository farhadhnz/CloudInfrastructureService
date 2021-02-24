using CloudInfrastructureService.Provider;
using CloudInfrastructureService.Resource;
using System;
using System.IO;

namespace ConsumerConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var provider = new IgsProvider();

            provider.DeleteInfrastructure(Directory.GetCurrentDirectory(), "Test");
            provider.DeleteInfrastructure(Directory.GetCurrentDirectory(), "UAT");

            provider.CreateInfrastructure(Directory.GetCurrentDirectory(), "Test");
            provider.CreateResource(Directory.GetCurrentDirectory(), new VMResource("VirtualMachine"), "Test", new WindowsVM());
            provider.CreateResource(Directory.GetCurrentDirectory(), new VMResource("VirtualMachineLinux"), "Test", new LinuxVM());

            provider.DeleteResource(Directory.GetCurrentDirectory(), "VirtualMachine", "Test");
            provider.CreateResource(Directory.GetCurrentDirectory(), new DatabaseResource("DatabaseServerSQL"), "UAT", new SqlDB());
            //provider.CreateInfrastructure(Directory.GetCurrentDirectory(), "Farhad");
        }
    }
}
