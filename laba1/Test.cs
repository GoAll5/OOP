using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks.Dataflow;

namespace laba1
{
    static class Test
    {
        static public void Pars()
        {

            Parser parsini = new Parser("C:\\Users\\1\\Desktop\\Work\\oop\\Pars\\laba1\\text.ini");
            //TEST COMMON
            Console.WriteLine("==============================TEST==============================");
            Console.WriteLine("------------------------COMMON------------------------");

            Console.Write("COMMON - StatisterTimeMs - string: ");
            Console.WriteLine(parsini.GetInfo<string>("COMMON", "StatisterTimeMs"));
            Console.WriteLine();

            Console.Write("COMMON - StatisterTimeMs - double: ");
            Console.WriteLine(parsini.GetInfo<double>("COMMON", "StatisterTimeMs"));
            Console.WriteLine();

            Console.Write("COMMON - StatisterTimeMs - int: ");
            Console.WriteLine(parsini.GetInfo<int>("COMMON", "StatisterTimeMs"));
            Console.WriteLine();

            Console.Write("COMMON - LogNCMD - string: ");
            Console.WriteLine(parsini.GetInfo<string>("COMMON", "LogNCMD"));
            Console.WriteLine();

            Console.Write("COMMON - LogNCMD - double: ");
            Console.WriteLine(parsini.GetInfo<double>("COMMON", "LogNCMD"));
            Console.WriteLine();

            Console.Write("COMMON - LogNCMD - int: ");
            Console.WriteLine(parsini.GetInfo<int>("COMMON", "LogNCMD"));
            Console.WriteLine();

            Console.Write("COMMON - LogXML - string: ");
            Console.WriteLine(parsini.GetInfo<string>("COMMON", "LogXML"));
            Console.WriteLine();

            Console.Write("COMMON - LogXML - double: ");
            Console.WriteLine(parsini.GetInfo<double>("COMMON", "LogXML"));
            Console.WriteLine();

            Console.Write("COMMON - LogXML - int: ");
            Console.WriteLine(parsini.GetInfo<int>("COMMON", "LogXML"));
            Console.WriteLine();

            Console.Write("COMMON - DiskCachePath - string: ");
            Console.WriteLine(parsini.GetInfo<string>("COMMON", "DiskCachePath"));
            Console.WriteLine();

            //Console.Write("COMMON - DiskCachePath - double: ");
            //Console.WriteLine(parsini.GetInfo<double>("COMMON", "DiskCachePath", "double"));
            //Console.WriteLine();

            //Console.Write("COMMON - DiskCachePath - int: ");
            //Console.WriteLine(parsini.GetInfo<int>("COMMON", "DiskCachePath", "int"));
            //Console.WriteLine();

            Console.Write("COMMON - OpenMPThreadsCount - string: ");
            Console.WriteLine(parsini.GetInfo<string>("COMMON", "OpenMPThreadsCount"));
            Console.WriteLine();

            Console.Write("COMMON - OpenMPThreadsCount - double: ");
            Console.WriteLine(parsini.GetInfo<double>("COMMON", "OpenMPThreadsCount"));
            Console.WriteLine();

            Console.Write("COMMON - OpenMPThreadsCount - int: ");
            Console.WriteLine(parsini.GetInfo<int>("COMMON", "OpenMPThreadsCount"));
            Console.WriteLine();

            Console.WriteLine("------------------------------------------------------");
            Console.WriteLine();

            Console.WriteLine("----------------------ADC DEV-------------------------");

            Console.Write("ADC DEV - BufferLenSeconds - string: ");
            Console.WriteLine(parsini.GetInfo<string>("ADCDEV", "BufferLenSeconds"));
            Console.WriteLine();

            Console.Write("ADC DEV - BufferLenSeconds - double: ");
            Console.WriteLine(parsini.GetInfo<double>("ADCDEV", "BufferLenSeconds"));
            Console.WriteLine();

            //Console.Write("ADC DEV - BufferLenSeconds - int: ");
            //Console.WriteLine(parsini.GetInfo<int>("ADC DEV", "BufferLenSeconds", "int"));
            //Console.WriteLine();

            Console.Write("ADC DEV - SampleRate - string: ");
            Console.WriteLine(parsini.GetInfo<string>("ADCDEV", "SampleRate"));
            Console.WriteLine();

            Console.Write("ADC DEV - SampleRate - double: ");
            Console.WriteLine(parsini.GetInfo<double>("ADCDEV", "SampleRate"));
            Console.WriteLine();

            //Console.Write("ADC DEV - SampleRate - int: ");
            //Console.WriteLine(parsini.GetInfo<int>("ADC DEV", "SampleRate", "int"));
            //Console.WriteLine();

            Console.Write("ADC DEV - Driver - string: ");
            Console.WriteLine(parsini.GetInfo<string>("ADCDEV", "Driver"));
            Console.WriteLine();

            Console.WriteLine("------------------------------------------------------");
            Console.WriteLine();

            Console.WriteLine("------------------------NCMD--------------------------");

            Console.Write("NCMD - EnableChannelControl - string: ");
            Console.WriteLine(parsini.GetInfo<string>("NCMD", "EnableChannelControl"));
            Console.WriteLine();

            Console.Write("NCMD - EnableChannelControl - double: ");
            Console.WriteLine(parsini.GetInfo<double>("NCMD", "EnableChannelControl"));
            Console.WriteLine();

            Console.Write("NCMD - EnableChannelControl - int: ");
            Console.WriteLine(parsini.GetInfo<int>("NCMD", "EnableChannelControl"));
            Console.WriteLine();

            Console.Write("NCMD - SampleRate - string: ");
            Console.WriteLine(parsini.GetInfo<string>("NCMD", "SampleRate"));
            Console.WriteLine();

            Console.Write("NCMD - SampleRate - double: ");
            Console.WriteLine(parsini.GetInfo<double>("NCMD", "SampleRate"));
            Console.WriteLine();

            //Console.Write("NCMD - SampleRate - int: ");
            //Console.WriteLine(parsini.GetInfo<int>("NCMD", "SampleRate", "int"));
            //Console.WriteLine();

            Console.Write("NCMD - TidPacketVersionForTidControlCommand - string: ");
            Console.WriteLine(parsini.GetInfo<string>("NCMD", "TidPacketVersionForTidControlCommand"));
            Console.WriteLine();

            Console.Write("NCMD - TidPacketVersionForTidControlCommand - double: ");
            Console.WriteLine(parsini.GetInfo<double>("NCMD", "TidPacketVersionForTidControlCommand"));
            Console.WriteLine();

            Console.Write("NCMD - TidPacketVersionForTidControlCommand - int: ");
            Console.WriteLine(parsini.GetInfo<int>("NCMD", "TidPacketVersionForTidControlCommand"));
            Console.WriteLine();

            Console.WriteLine("------------------------------------------------------");
            Console.WriteLine();

            Console.WriteLine("-----------------------LEGACY_XML---------------------");

            Console.Write("LEGACY_XML - ListenTcpPort - string: ");
            Console.WriteLine(parsini.GetInfo<string>("LEGACY_XML", "ListenTcpPort"));
            Console.WriteLine();

            Console.Write("LEGACY_XML - ListenTcpPort - double: ");
            Console.WriteLine(parsini.GetInfo<double>("LEGACY_XML", "ListenTcpPort"));
            Console.WriteLine();

            Console.Write("LEGACY_XML - ListenTcpPort - int: ");
            Console.WriteLine(parsini.GetInfo<int>("LEGACY_XML", "ListenTcpPort"));
            Console.WriteLine();


            Console.WriteLine("------------------------------------------------------");
            Console.WriteLine();

            Console.WriteLine("---------------------------DEBUG----------------------");

            Console.Write("DEBUG - PlentySockMaxQSize - string: ");
            Console.WriteLine(parsini.GetInfo<string>("DEBUG", "PlentySockMaxQSize"));
            Console.WriteLine();

            Console.Write("DEBUG - PlentySockMaxQSize - double: ");
            Console.WriteLine(parsini.GetInfo<double>("DEBUG", "PlentySockMaxQSize"));
            Console.WriteLine();

            Console.Write("DEBUG - PlentySockMaxQSize - int: ");
            Console.WriteLine(parsini.GetInfo<int>("DEBUG", "PlentySockMaxQSize"));
            Console.WriteLine();

            Console.WriteLine("------------------------------------------------------");
            Console.WriteLine();

            Console.WriteLine("================================================================");

        }
    }
}
