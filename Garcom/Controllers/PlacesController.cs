﻿using System;
using System.Collections.Generic;
using System.Web.Mvc;
using Garcom.Models;

namespace Garcom.Controllers
{
    public class PlacesController : Controller
    {
        private readonly AllPlaces _allPlaces;

        public PlacesController(AllPlaces allPlaces)
        {
            _allPlaces = allPlaces;
        }

        public ViewResult New()
        {
            return View();
        }

        public ViewResult Index()
        {
            return View("index", _allPlaces.All);
        }

        public ActionResult ListOfPlaces()
        {
            return PartialView("_listOfPlaces", _allPlaces.All);
        }

        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult Create(Place place)
        {
            _allPlaces.Save(place);
            return RedirectToAction("index","places");
        }

        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult CreateAjax(Place place)
        {
            _allPlaces.Save(place);
            return new EmptyResult();
        }
    }
}