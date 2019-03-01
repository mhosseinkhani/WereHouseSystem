using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using itka.Services;
using itka.Models;
using System.Threading.Tasks;
using itka.ViewModels;

namespace itka.Controllers
{
    public class AppController : Controller
    {
        // GET: App
        public ActionResult Index()
        {
            return View();
        }
        // DATATABLES
        public ActionResult Products()
        {           
            return View("Products");
        }
        public ActionResult Clients()
        {
           return View("Clients");
        }
        public ActionResult Units()
        {
            return View("Units");
        }
        public ActionResult Suppliers()
        {          
            return View("Suppliers");
        }
        public ActionResult Warehouses()
        {
            return View("Warehouses");
        }
        // DATATABLES AJAX LOAD FUNCTIONS
        public async Task<JsonResult> GetUnits(string start, string length, string order, string search)
        {
            try
            {
                var searchkey = Request.QueryString["search[value]"];
                var services = new RetrieveServices();
                var model = services.GetUnitsDatatable(start, length, searchkey);
                List<DatatableResultsViewModel> jsonResult = new List<DatatableResultsViewModel>();
                foreach (var item in model)
                {
                    var _actions = "";
                    _actions += "<span class='pull-right'>";
                    _actions += "<button class='btn btn-icon waves-effect waves-light btn-success' data-url='ViewUnit'  data-subject='njësinë " + item.name+ "' data-table='UnitsTbl' data-id='" + item.id + "' onclick='GetViewModal(this)'><i class='fa fa-eye'></i></button>&nbsp;&nbsp;";
                    _actions += "<button class='btn btn-icon waves-effect waves-light btn-warning' data-url='EditUnit'  data-subject='njësinë " + item.name + "' data-table='UnitsTbl' data-id='" + item.id + "' data-form='SaveChangesUnitForm' onclick='GetEditModal(this)'><i class='fa fa-edit'></i></button>&nbsp;&nbsp;";
                    _actions += "<button class='btn btn-icon waves-effect waves-light btn-danger' data-url='DeleteUnit' data-subject='njësinë " + item.name + "' data-table='UnitsTbl' data-id='" + item.id + "' onclick='GetDeleteSwal(this)'><i class='fa fa-trash'></i></button>&nbsp;&nbsp;";
                    _actions += " </span>";
                    DatatableResultsViewModel itm = new DatatableResultsViewModel()
                    {
                        id = item.id,
                        name = item.name,
                        description = item.description,
                        actions = _actions
                    };
                    jsonResult.Add(itm);

                }
                return Json(new { data = jsonResult }, JsonRequestBehavior.AllowGet);
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        public async Task<JsonResult> GetSuppliers(string start, string length, string order, string search)
        {
            try
            {
                var searchkey = Request.QueryString["search[value]"];
                var services = new RetrieveServices();
                var model = services.GetSuppliersDatatable(start, length, searchkey);
                List<DatatableResultsViewModel> jsonResult = new List<DatatableResultsViewModel>();
                foreach (var item in model)
                {
                    var _actions = "";
                    _actions += "<span class='pull-right'>";
                    _actions += "<button class='btn btn-icon waves-effect waves-light btn-success' data-url='ViewSupplier'  data-subject='furnitorin " + item.name + "' data-table='SuppliersTbl' data-id='" + item.id + "' onclick='GetViewModal(this)'><i class='fa fa-eye'></i></button>&nbsp;&nbsp;";
                    _actions += "<button class='btn btn-icon waves-effect waves-light btn-warning' data-url='EditSupplier'  data-subject='furnitorin " + item.name + "' data-table='SuppliersTbl' data-id='" + item.id + "' data-form='SaveChangesSupplierForm' onclick='GetEditModal(this)'><i class='fa fa-edit'></i></button>&nbsp;&nbsp;";
                    _actions += "<button class='btn btn-icon waves-effect waves-light btn-danger' data-url='DeleteSupplier' data-subject='furnitorin " + item.name + "' data-table='SuppliersTbl' data-id='" + item.id + "' onclick='GetDeleteSwal(this)'><i class='fa fa-trash'></i></button>&nbsp;&nbsp;";
                    _actions += " </span>";
                    DatatableResultsViewModel itm = new DatatableResultsViewModel()
                    {
                        id = item.id,
                        company = item.company,
                        name = item.name,
                        surname = item.surname,
                        email = item.email,
                        phone1 = item.phone1,
                        nipt = item.nipt,                     
                        actions = _actions
                    };
                    jsonResult.Add(itm);

                }
                return Json(new { data = jsonResult }, JsonRequestBehavior.AllowGet);
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        public async Task<JsonResult> GetClients(string start, string length, string order, string search)
        {
            try
            {
                var searchkey = Request.QueryString["search[value]"];
                var services = new RetrieveServices();
                var model = services.GetClientsDatatable(start, length, searchkey);
                List<DatatableResultsViewModel> jsonResult = new List<DatatableResultsViewModel>();
                foreach (var item in model)
                {
                    var _actions = "";
                    _actions += "<span class='pull-right'>";
                    _actions += "<button class='btn btn-icon waves-effect waves-light btn-success' data-url='ViewClient'  data-subject='klientin " + item.name + "' data-table='ClientsTbl' data-id='" + item.id + "' onclick='GetViewModal(this)'><i class='fa fa-eye'></i></button>&nbsp;&nbsp;";
                    _actions += "<button class='btn btn-icon waves-effect waves-light btn-warning' data-url='EditClient'  data-subject='klientin " + item.name + "' data-table='ClientsTbl' data-id='" + item.id + "' data-form='SaveChangesClientForm' onclick='GetEditModal(this)'><i class='fa fa-edit'></i></button>&nbsp;&nbsp;";
                    _actions += "<button class='btn btn-icon waves-effect waves-light btn-danger' data-url='DeleteClient' data-subject='klientin " + item.name + "' data-table='ClientsTbl' data-id='" + item.id + "' onclick='GetDeleteSwal(this)'><i class='fa fa-trash'></i></button>&nbsp;&nbsp;";
                    _actions += " </span>";
                    DatatableResultsViewModel itm = new DatatableResultsViewModel()
                    {
                        id = item.id,
                        company = item.company,
                        name = item.name,
                        surname = item.surname,
                        email = item.email,
                        phone1 = item.phone1,
                        nipt = item.nipt,
                        actions = _actions
                    };
                    jsonResult.Add(itm);

                }
                return Json(new { data = jsonResult }, JsonRequestBehavior.AllowGet);
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        public async Task<JsonResult> GetWarehouses(string start, string length, string order, string search)
        {
            try
            {
                var searchkey = Request.QueryString["search[value]"];
                var services = new RetrieveServices();
                var model = services.GetWarehousesDatatable(start, length, searchkey);
                List<DatatableResultsViewModel> jsonResult = new List<DatatableResultsViewModel>();
                foreach (var item in model)
                {
                    var _actions = "";
                    _actions += "<span class='pull-right'>";
                    _actions += "<button class='btn btn-icon waves-effect waves-light btn-success' data-url='ViewWarehouse'  data-subject='magazinën " + item.name + "' data-table='WarehousesTbl' data-id='" + item.id + "' onclick='GetViewModal(this)'><i class='fa fa-eye'></i></button>&nbsp;&nbsp;";
                    _actions += "<button class='btn btn-icon waves-effect waves-light btn-warning' data-url='EditWarehouse'  data-subject='magazinën " + item.name + "' data-table='WarehousesTbl' data-id='" + item.id + "' data-form='SaveChangesWarehouseForm' onclick='GetEditModal(this)'><i class='fa fa-edit'></i></button>&nbsp;&nbsp;";
                    _actions += "<button class='btn btn-icon waves-effect waves-light btn-danger' data-url='DeleteWarehouse' data-subject='magazinën " + item.name + "' data-table='WarehousesTbl' data-id='" + item.id + "' onclick='GetDeleteSwal(this)'><i class='fa fa-trash'></i></button>&nbsp;&nbsp;";
                    _actions += " </span>";
                    DatatableResultsViewModel itm = new DatatableResultsViewModel()
                    {
                        id = item.id,
                        name = item.name,
                        address = item.address,
                        description = item.description,                      
                        actions = _actions
                    };
                    jsonResult.Add(itm);

                }
                return Json(new { data = jsonResult }, JsonRequestBehavior.AllowGet);
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        public async Task<JsonResult> GetProducts(string start, string length, string order, string search)
        {
            try
            {
                var searchkey = Request.QueryString["search[value]"];
                var services = new RetrieveServices();
                var model = services.GetProductsDatatable(start, length, searchkey);
                List<DatatableResultsViewModel> jsonResult = new List<DatatableResultsViewModel>();
                foreach (var item in model)
                {
                    var _actions = "";
                    _actions += "<span class='pull-right'>";
                    _actions += "<button class='btn btn-icon waves-effect waves-light btn-success' data-url='ViewProduct'  data-subject='artikullin " + item.Product.name + "' data-table='ProductsTbl' data-id='" + item.Product.id + "' onclick='GetViewModal(this)'><i class='fa fa-eye'></i></button>&nbsp;&nbsp;";
                    _actions += "<button class='btn btn-icon waves-effect waves-light btn-warning' data-url='EditProduct'  data-subject='artikullin " + item.Product.name + "' data-table='ProductsTbl' data-id='" + item.Product.id + "' data-form='SaveChangesProductForm' onclick='GetEditModal(this)'><i class='fa fa-edit'></i></button>&nbsp;&nbsp;";
                    _actions += "<button class='btn btn-icon waves-effect waves-light btn-danger' data-url='DeleteProduct' data-subject='artikullin " + item.Product.name + "' data-table='ProductsTbl' data-id='" + item.Product.id + "' onclick='GetDeleteSwal(this)'><i class='fa fa-trash'></i></button>&nbsp;&nbsp;";
                    _actions += " </span>";
                    DatatableResultsViewModel itm = new DatatableResultsViewModel()
                    {
                        id = item.Product.id,
                        name = item.Product.name,
                        number = item.Product.number,
                        description = item.Product.description,
                        unit = item.unit,
                        minquantity = item.Product.minquantity,
                        actions = _actions
                    };
                    jsonResult.Add(itm);

                }
                return Json(new { data = jsonResult }, JsonRequestBehavior.AllowGet);
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        // DELETE FUNCTIONS
        [HttpPost]
        public JsonResult DeleteUnit(int id)
        {
            var service = new DeleteServices();
            var res = service.DeleteUnit(id);
            if (res)
                return Json(new { success = true });

            else
                return Json(new { success = false });
        }
        [HttpPost]
        public JsonResult DeleteProduct(int id)
        {
            var service = new DeleteServices();
            var res = service.DeleteProduct(id);
            if (res)
                return Json(new { success = true });

            else
                return Json(new { success = false });
        }
        [HttpPost]
        public JsonResult DeleteSupplier(int id)
        {
            var service = new DeleteServices();
            var res = service.DeleteSupplier(id);
            if (res)
                return Json(new { success = true });

            else
                return Json(new { success = false });
        }
        [HttpPost]
        public JsonResult DeleteClient(int id)
        {
            var service = new DeleteServices();
            var res = service.DeleteClient(id);
            if (res)
                return Json(new { success = true });

            else
                return Json(new { success = false });
        }
        [HttpPost]
        public JsonResult DeleteWarehouse(int id)
        {
            var service = new DeleteServices();
            var res = service.DeleteWarehouse(id);
            if (res)
                return Json(new { success = true });

            else
                return Json(new { success = false });
        }
        // CREATE FUNCTIONS
        public ActionResult CreateUnit()
        {
            return PartialView("_CreateUnit");
        }
        public ActionResult CreateSupplier()
        {
            return PartialView("_CreateSupplier");
        }
        public ActionResult CreateProduct()
        {
            var services = new RetrieveServices();
            ProductViewModel model = new ProductViewModel()
            {
                Units = services.GetUnits()
            };
            return PartialView("_CreateProduct", model);
        }
        public ActionResult CreateClient()
        {
            return PartialView("_CreateClient");
        }
        public ActionResult CreateWarehouse()
        {
            return PartialView("_CreateWarehouse");
        }
        //SAVE FUNCTIONS
        [HttpPost]
        public JsonResult SaveUnit(tblUnit model)
        {
            var service = new CreateServices();
            var res = service.SaveUnit(model);
            if (res)
                return Json(new { success = true });

            else
                return Json(new { success = false });
        }
        [HttpPost]
        public JsonResult SaveSupplier(tblSupplier model)
        {
            var service = new CreateServices();
            var res = service.SaveSupplier(model);
            if (res)
                return Json(new { success = true });

            else
                return Json(new { success = false });
        }
        [HttpPost]
        public JsonResult SaveProduct(ProductViewModel model)
        {
            var service = new CreateServices();
            var res = service.SaveProduct(model);
            if (res)
                return Json(new { success = true });

            else
                return Json(new { success = false });
        }
        [HttpPost]
        public JsonResult SaveClient(tblClient model)
        {
            var service = new CreateServices();
            var res = service.SaveClient(model);
            if (res)
                return Json(new { success = true });

            else
                return Json(new { success = false });
        }
        [HttpPost]
        public async Task<JsonResult> SaveWarehouse(tblWarehouse model)
        {
            var service = new CreateServices();
            var res =await service.SaveWarehouse(model);
            if (res)
                return Json(new { success = true });

            else
                return Json(new { success = false });
        }
        //DETAILS FUNCTIONS
        [HttpPost]
        public ActionResult ViewUnit(int id)
        {
            var services = new DetailsServices();
            var model = services.UnitDetails(id);
            return PartialView("_ViewUnit", model);
        }
        [HttpPost]
        public ActionResult ViewSupplier(int id)
        {
            var services = new DetailsServices();
            var model = services.SupplierDetails(id);
            return PartialView("_ViewSupplier", model);
        }
        [HttpPost]
        public ActionResult ViewProduct(int id)
        {
            var services = new DetailsServices();
            var model = services.ProductDetails(id);
            return PartialView("_ViewProduct", model);
        }
        [HttpPost]
        public ActionResult ViewClient(int id)
        {
            var services = new DetailsServices();
            var model = services.ClientDetails(id);
            return PartialView("_ViewClient", model);
        }
        [HttpPost]
        public ActionResult ViewWarehouse(int id)
        {
            var services = new DetailsServices();
            var model = services.WarehouseDetails(id);
            return PartialView("_ViewWarehouse", model);
        }
        //EDIT FUNCTIONS
        [HttpPost]
        public ActionResult EditUnit(int id)
        {
            var services = new DetailsServices();
            var model = services.UnitDetails(id);
            return PartialView("_EditUnit", model);
        }
        [HttpPost]
        public ActionResult EditSupplier(int id)
        {
            var services = new DetailsServices();
            var model = services.SupplierDetails(id);
            return PartialView("_EditSupplier", model);
        }
        [HttpPost]
        public ActionResult EditProduct(int id)
        {
            var services = new DetailsServices();
            var model = services.ProductDetails(id);
            return PartialView("_EditProduct", model);
        }
        [HttpPost]
        public ActionResult EditClient(int id)
        {
            var services = new DetailsServices();
            var model = services.ClientDetails(id);
            return PartialView("_EditClient", model);
        }
        [HttpPost]
        public ActionResult EditWarehouse(int id)
        {
            var services = new DetailsServices();
            var model = services.WarehouseDetails(id);
            return PartialView("_EditWarehouse", model);
        }
        // UPDATE FUNCTIONS
        [HttpPost]
        public JsonResult UpdateUnit(tblUnit model)
        {
            var service = new UpdateServices();
            var res = service.SaveChangesUnit(model);
            if (res)
                return Json(new { success = true });

            else
                return Json(new { success = false });
        }
        [HttpPost]
        public JsonResult UpdateSupplier(tblSupplier model)
        {
            var service = new UpdateServices();
            var res = service.SaveChangesSupplier(model);
            if (res)
                return Json(new { success = true });

            else
                return Json(new { success = false });
        }
        [HttpPost]
        public JsonResult UpdateClient(tblClient model)
        {
            var service = new UpdateServices();
            var res = service.SaveChangesClient(model);
            if (res)
                return Json(new { success = true });

            else
                return Json(new { success = false });
        }
        [HttpPost]
        public JsonResult UpdateWarehouse(tblWarehouse model)
        {
            var service = new UpdateServices();
            var res = service.SaveChangesWarehouse(model);
            if (res)
                return Json(new { success = true });

            else
                return Json(new { success = false });
        }
        [HttpPost]
        public JsonResult UpdateProduct(tblSupplier model)
        {
            var service = new UpdateServices();
            var res = service.SaveChangesSupplier(model);
            if (res)
                return Json(new { success = true });

            else
                return Json(new { success = false });
        }
    }
}