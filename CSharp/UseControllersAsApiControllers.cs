var json = JsonConvert.SerializeObject(results, Formatting.Indented);
return new JsonResult { Data = json, JsonRequestBehavior = JsonRequestBehavior.AllowGet };



// Just use an ApiController instead and call
return Json(results);
