﻿using Microsoft.EntityFrameworkCore;
using Shared.PatternsBase.Command.classes;
using Shared.PatternsBase.Command.interfaces;
using StarshipAPI.Shared.PatternsBase.Command.classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StarshipAPI.Controllers.MaintenanceSectorController.Commands
{
    public class RepairShipHullCommand : CommandWithDbContext, ICommandFactory
    {
        public string CommandName { get { return "RepairShipHullCommand"; } }

        public string CommandDescription { get { return "Utilize resources, credits and energy to repair the ship hull"; } }

        public RepairShipHullCommand(DbContext context) : base(context) { }

        public override void Execute()
        {
            Console.WriteLine("Get Current Ship Location In DB");
            Console.WriteLine("Randomly check if Resources are available using Encounter Engine");
            Console.WriteLine("Store Resource in DB if Encounter Generator Shows Positive Hit");
            Console.WriteLine("Sending Response with details about result...");
        }

        public ICommand MakeCommand(CommandExecuteParams arguments)
        {
            return new RepairShipHullCommand(this.Context);
        }

        public override void Validate()
        {
            Console.WriteLine("Run Validation Against Params or Data in DB");
        }

        public override void Undo()
        {
            throw new NotImplementedException();
        }
    }
}
