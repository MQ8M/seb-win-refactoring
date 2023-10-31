/*
 * Copyright (c) 2023 ETH Zürich, Educational Development and Technology (LET)
 * 
 * This Source Code Form is subject to the terms of the Mozilla Public
 * License, v. 2.0. If a copy of the MPL was not distributed with this
 * file, You can obtain one at http://mozilla.org/MPL/2.0/.
 */

using System.Linq;
using SafeExamBrowser.Logging.Contracts;
using SafeExamBrowser.SystemComponents.Contracts;
using SafeExamBrowser.SystemComponents.Contracts.Registry;

namespace SafeExamBrowser.SystemComponents
{
    public class VirtualMachineDetector : IVirtualMachineDetector
    {
        private const string MANIPULATED = "000000000000";
        private const string QEMU_MAC_PREFIX = "525400";
        private const string VIRTUALBOX_MAC_PREFIX = "080027";

        private static readonly string[] DeviceBlacklist =
        {
            // Hyper-V
            "PROD_VIRTUAL", "HYPER_V",
            // QEMU
            "qemu", "ven_1af4", "ven_1b36", "subsys_11001af4",
            // VirtualBox
            "vbox", "vid_80ee",
            // VMware
            "PROD_VMWARE", "VEN_VMWARE", "VMWARE_IDE"
        };

        private static readonly string[] DeviceWhitelist =
        {
            // Microsoft Virtual Disk Device
            "PROD_VIRTUAL_DISK",
            // Microsoft Virtual DVD Device
            "PROD_VIRTUAL_DVD"
        };

        private readonly ILogger logger;
        private readonly IRegistry registry;
        private readonly ISystemInfo systemInfo;

        public VirtualMachineDetector(ILogger logger, IRegistry registry, ISystemInfo systemInfo)
        {
            this.logger = logger;
            this.registry = registry;
            this.systemInfo = systemInfo;
        }

        public bool IsVirtualMachine()
        {
            return false; // Disabling overall detection
        }

        private bool HasVirtualDevice()
        {
            return false; // Disabling virtual device detection
        }

        private bool HasVirtualMacAddress()
        {
            return false; // Disabling MAC address-based virtual machine detection
        }

        private bool IsVirtualCpu()
        {
            return false; // Disabling CPU-based virtual machine detection
        }

        private bool IsVirtualRegistry()
        {
            return false; // Disabling registry-based virtual machine detection
        }

        private bool IsVirtualSystem(string biosInfo, string manufacturer, string model)
        {
            return false; // Disabling system-based virtual machine detection
        }
    }
}
