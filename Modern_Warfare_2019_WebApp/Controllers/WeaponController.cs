using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Modern_Warfare_2019_WebApp.Models;

namespace Modern_Warfare_2019_WebApp.Controllers
{
   
    public class WeaponController : Controller
    { 
        //intialize soldier object
        private Soldier soldier;

        public IActionResult Index()
        {

            return View();
        }

        public IActionResult SoldierLayout(string CodeName)
        {
            switch (CodeName)
            {
                case "Terminator":
                    {
                        //create a terminator object
                        Terminator term = new Terminator();

                        //set the soldier object to terminator
                        soldier = term;
                        return View(term);

                    }

                case "RunAndGun":
                    {
                        //create a run and un object
                        RunAndGun gunna = new RunAndGun();
                        soldier = gunna;
                        return View(gunna);
                    }

                case "SkullCrusher":
                    {
                        //create Skull crusher object
                        SkullCrusher crush = new SkullCrusher();
                        soldier = crush;
                        return View(crush);
                    }

                case "Surgeon":
                    {
                        //Create surgeon object
                        Surgeon precise = new Surgeon();
                        soldier = precise;
                        return View(precise);
                    }
                default:
                    {
                        return View();
                    }
            }
        }

        public IActionResult KDRatio()
        {
            return View();
        }

        public IActionResult ViewKDRatio(double Kills, double Deaths)
        {
            Soldier s = new Terminator
            {
                Kills = Kills,
                Deaths = Deaths
            };

            return View(s);
        }
    }
}