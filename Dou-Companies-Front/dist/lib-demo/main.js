(window["webpackJsonp"] = window["webpackJsonp"] || []).push([["main"],{

/***/ "./src/$$_lazy_route_resource lazy recursive":
/*!**********************************************************!*\
  !*** ./src/$$_lazy_route_resource lazy namespace object ***!
  \**********************************************************/
/*! no static exports found */
/***/ (function(module, exports) {

function webpackEmptyAsyncContext(req) {
	// Here Promise.resolve().then() is used instead of new Promise() to prevent
	// uncaught exception popping up in devtools
	return Promise.resolve().then(function() {
		var e = new Error("Cannot find module '" + req + "'");
		e.code = 'MODULE_NOT_FOUND';
		throw e;
	});
}
webpackEmptyAsyncContext.keys = function() { return []; };
webpackEmptyAsyncContext.resolve = webpackEmptyAsyncContext;
module.exports = webpackEmptyAsyncContext;
webpackEmptyAsyncContext.id = "./src/$$_lazy_route_resource lazy recursive";

/***/ }),

/***/ "./src/app/app-routing/app-routing.module.ts":
/*!***************************************************!*\
  !*** ./src/app/app-routing/app-routing.module.ts ***!
  \***************************************************/
/*! exports provided: AppRoutingModule */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "AppRoutingModule", function() { return AppRoutingModule; });
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! @angular/core */ "./node_modules/@angular/core/fesm5/core.js");
/* harmony import */ var _angular_router__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/router */ "./node_modules/@angular/router/fesm5/router.js");
/* harmony import */ var _companies_companies_component__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! ../companies/companies.component */ "./src/app/companies/companies.component.ts");
/* harmony import */ var _reviews_reviews_component__WEBPACK_IMPORTED_MODULE_3__ = __webpack_require__(/*! ../reviews/reviews.component */ "./src/app/reviews/reviews.component.ts");
var __decorate = (undefined && undefined.__decorate) || function (decorators, target, key, desc) {
    var c = arguments.length, r = c < 3 ? target : desc === null ? desc = Object.getOwnPropertyDescriptor(target, key) : desc, d;
    if (typeof Reflect === "object" && typeof Reflect.decorate === "function") r = Reflect.decorate(decorators, target, key, desc);
    else for (var i = decorators.length - 1; i >= 0; i--) if (d = decorators[i]) r = (c < 3 ? d(r) : c > 3 ? d(target, key, r) : d(target, key)) || r;
    return c > 3 && r && Object.defineProperty(target, key, r), r;
};




var routes = [
    {
        path: '',
        component: _companies_companies_component__WEBPACK_IMPORTED_MODULE_2__["CompaniesComponent"],
    },
    {
        path: 'reviews',
        component: _reviews_reviews_component__WEBPACK_IMPORTED_MODULE_3__["ReviewsComponent"],
    },
];
var AppRoutingModule = /** @class */ (function () {
    function AppRoutingModule() {
    }
    AppRoutingModule = __decorate([
        Object(_angular_core__WEBPACK_IMPORTED_MODULE_0__["NgModule"])({
            imports: [
                _angular_router__WEBPACK_IMPORTED_MODULE_1__["RouterModule"].forRoot(routes)
            ],
            exports: [
                _angular_router__WEBPACK_IMPORTED_MODULE_1__["RouterModule"]
            ],
            declarations: []
        })
    ], AppRoutingModule);
    return AppRoutingModule;
}());



/***/ }),

/***/ "./src/app/app.component.css":
/*!***********************************!*\
  !*** ./src/app/app.component.css ***!
  \***********************************/
/*! no static exports found */
/***/ (function(module, exports) {

module.exports = "table {\r\n    width: 100%;\r\n}"

/***/ }),

/***/ "./src/app/app.component.html":
/*!************************************!*\
  !*** ./src/app/app.component.html ***!
  \************************************/
/*! no static exports found */
/***/ (function(module, exports) {

module.exports = "<router-outlet></router-outlet>"

/***/ }),

/***/ "./src/app/app.component.ts":
/*!**********************************!*\
  !*** ./src/app/app.component.ts ***!
  \**********************************/
/*! exports provided: AppComponent */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "AppComponent", function() { return AppComponent; });
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! @angular/core */ "./node_modules/@angular/core/fesm5/core.js");
var __decorate = (undefined && undefined.__decorate) || function (decorators, target, key, desc) {
    var c = arguments.length, r = c < 3 ? target : desc === null ? desc = Object.getOwnPropertyDescriptor(target, key) : desc, d;
    if (typeof Reflect === "object" && typeof Reflect.decorate === "function") r = Reflect.decorate(decorators, target, key, desc);
    else for (var i = decorators.length - 1; i >= 0; i--) if (d = decorators[i]) r = (c < 3 ? d(r) : c > 3 ? d(target, key, r) : d(target, key)) || r;
    return c > 3 && r && Object.defineProperty(target, key, r), r;
};

var AppComponent = /** @class */ (function () {
    function AppComponent() {
    }
    AppComponent.prototype.ngOnInit = function () { };
    AppComponent = __decorate([
        Object(_angular_core__WEBPACK_IMPORTED_MODULE_0__["Component"])({
            selector: 'app-root',
            template: __webpack_require__(/*! ./app.component.html */ "./src/app/app.component.html"),
            styles: [__webpack_require__(/*! ./app.component.css */ "./src/app/app.component.css")]
        })
    ], AppComponent);
    return AppComponent;
}());



/***/ }),

/***/ "./src/app/app.module.ts":
/*!*******************************!*\
  !*** ./src/app/app.module.ts ***!
  \*******************************/
/*! exports provided: AppModule */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "AppModule", function() { return AppModule; });
/* harmony import */ var _angular_platform_browser__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! @angular/platform-browser */ "./node_modules/@angular/platform-browser/fesm5/platform-browser.js");
/* harmony import */ var _angular_platform_browser_animations__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/platform-browser/animations */ "./node_modules/@angular/platform-browser/fesm5/animations.js");
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! @angular/core */ "./node_modules/@angular/core/fesm5/core.js");
/* harmony import */ var _angular_common_http__WEBPACK_IMPORTED_MODULE_3__ = __webpack_require__(/*! @angular/common/http */ "./node_modules/@angular/common/fesm5/http.js");
/* harmony import */ var _app_routing_app_routing_module__WEBPACK_IMPORTED_MODULE_4__ = __webpack_require__(/*! ./app-routing/app-routing.module */ "./src/app/app-routing/app-routing.module.ts");
/* harmony import */ var _angular_material__WEBPACK_IMPORTED_MODULE_5__ = __webpack_require__(/*! @angular/material */ "./node_modules/@angular/material/esm5/material.es5.js");
/* harmony import */ var _app_component__WEBPACK_IMPORTED_MODULE_6__ = __webpack_require__(/*! ./app.component */ "./src/app/app.component.ts");
/* harmony import */ var _companies_companies_component__WEBPACK_IMPORTED_MODULE_7__ = __webpack_require__(/*! ./companies/companies.component */ "./src/app/companies/companies.component.ts");
/* harmony import */ var _reviews_reviews_component__WEBPACK_IMPORTED_MODULE_8__ = __webpack_require__(/*! ./reviews/reviews.component */ "./src/app/reviews/reviews.component.ts");
var __decorate = (undefined && undefined.__decorate) || function (decorators, target, key, desc) {
    var c = arguments.length, r = c < 3 ? target : desc === null ? desc = Object.getOwnPropertyDescriptor(target, key) : desc, d;
    if (typeof Reflect === "object" && typeof Reflect.decorate === "function") r = Reflect.decorate(decorators, target, key, desc);
    else for (var i = decorators.length - 1; i >= 0; i--) if (d = decorators[i]) r = (c < 3 ? d(r) : c > 3 ? d(target, key, r) : d(target, key)) || r;
    return c > 3 && r && Object.defineProperty(target, key, r), r;
};









var AppModule = /** @class */ (function () {
    function AppModule() {
    }
    AppModule = __decorate([
        Object(_angular_core__WEBPACK_IMPORTED_MODULE_2__["NgModule"])({
            declarations: [
                _app_component__WEBPACK_IMPORTED_MODULE_6__["AppComponent"],
                _companies_companies_component__WEBPACK_IMPORTED_MODULE_7__["CompaniesComponent"],
                _reviews_reviews_component__WEBPACK_IMPORTED_MODULE_8__["ReviewsComponent"]
            ],
            imports: [
                _angular_platform_browser__WEBPACK_IMPORTED_MODULE_0__["BrowserModule"],
                _angular_platform_browser_animations__WEBPACK_IMPORTED_MODULE_1__["BrowserAnimationsModule"],
                _angular_common_http__WEBPACK_IMPORTED_MODULE_3__["HttpClientModule"],
                _angular_material__WEBPACK_IMPORTED_MODULE_5__["MatTableModule"],
                _angular_material__WEBPACK_IMPORTED_MODULE_5__["MatSortModule"],
                _angular_material__WEBPACK_IMPORTED_MODULE_5__["MatPaginatorModule"],
                _app_routing_app_routing_module__WEBPACK_IMPORTED_MODULE_4__["AppRoutingModule"],
                _angular_material__WEBPACK_IMPORTED_MODULE_5__["MatFormFieldModule"],
                _angular_material__WEBPACK_IMPORTED_MODULE_5__["MatNativeDateModule"],
                _angular_material__WEBPACK_IMPORTED_MODULE_5__["MatInputModule"],
                _angular_material__WEBPACK_IMPORTED_MODULE_5__["MatButtonModule"],
                _angular_material__WEBPACK_IMPORTED_MODULE_5__["MatCardModule"]
            ],
            providers: [],
            bootstrap: [_app_component__WEBPACK_IMPORTED_MODULE_6__["AppComponent"]]
        })
    ], AppModule);
    return AppModule;
}());



/***/ }),

/***/ "./src/app/companies/companies.component.css":
/*!***************************************************!*\
  !*** ./src/app/companies/companies.component.css ***!
  \***************************************************/
/*! no static exports found */
/***/ (function(module, exports) {

module.exports = "table {\n  width: 100%;\n}\n\n.mat-form-field {\n  font-size: 14px;\n  width: 100%;\n}\n\ntd, th {\n  width: 25%;\n}\n"

/***/ }),

/***/ "./src/app/companies/companies.component.html":
/*!****************************************************!*\
  !*** ./src/app/companies/companies.component.html ***!
  \****************************************************/
/*! no static exports found */
/***/ (function(module, exports) {

module.exports = "<mat-form-field>\n  <input matInput (keyup)=\"applyFilter($event.target.value)\" placeholder=\"Search for companies by name\">\n</mat-form-field>\n\n<div class=\"mat-elevation-z2\">\n  <table mat-table [dataSource]=\"dataSource\" matSort>\n\n    <ng-container matColumnDef=\"Name\">\n      <th mat-header-cell *matHeaderCellDef mat-sort-header> Name </th>\n      <td mat-cell *matCellDef=\"let row\"> {{ row.Name }} </td>\n    </ng-container>\n\n    <ng-container matColumnDef=\"Score\">\n      <th mat-header-cell *matHeaderCellDef mat-sort-header> Score </th>\n      <td mat-cell *matCellDef=\"let row\"> {{ row.Score }} </td>\n    </ng-container>\n\n    <ng-container matColumnDef=\"ReviewsCount\">\n      <th mat-header-cell *matHeaderCellDef mat-sort-header> ReviewsCount </th>\n      <td mat-cell *matCellDef=\"let row\"> {{ row.ReviewsCount }} </td>\n    </ng-container>\n\n    <ng-container matColumnDef=\"SentimentAnalysisScore\">\n      <th mat-header-cell *matHeaderCellDef mat-sort-header> SentimentAnalysisScore </th>\n      <td mat-cell *matCellDef=\"let row\"> {{ row.SentimentAnalysisScore }} </td>\n    </ng-container>\n\n    <ng-container matColumnDef=\"actions\">\n      <th mat-header-cell *matHeaderCellDef> Reviews </th>\n      <td mat-cell *matCellDef=\"let row; let i = index;\">\n        <button mat-button (click)=\"onClick(row)\">Go</button>\n      </td>\n    </ng-container>\n    <tr mat-header-row *matHeaderRowDef=\"displayedColumns\">\n    </tr>\n    <tr mat-row *matRowDef=\"let row; columns: displayedColumns;\">\n    </tr>\n  </table>\n\n  <mat-paginator [pageSizeOptions]=\"[10, 25, 50]\"></mat-paginator>\n</div>"

/***/ }),

/***/ "./src/app/companies/companies.component.ts":
/*!**************************************************!*\
  !*** ./src/app/companies/companies.component.ts ***!
  \**************************************************/
/*! exports provided: CompaniesComponent */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "CompaniesComponent", function() { return CompaniesComponent; });
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! @angular/core */ "./node_modules/@angular/core/fesm5/core.js");
/* harmony import */ var _angular_material__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/material */ "./node_modules/@angular/material/esm5/material.es5.js");
/* harmony import */ var _angular_common_http__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! @angular/common/http */ "./node_modules/@angular/common/fesm5/http.js");
/* harmony import */ var odata_data_source__WEBPACK_IMPORTED_MODULE_3__ = __webpack_require__(/*! odata-data-source */ "./node_modules/odata-data-source/fesm5/odata-data-source.js");
/* harmony import */ var _angular_router__WEBPACK_IMPORTED_MODULE_4__ = __webpack_require__(/*! @angular/router */ "./node_modules/@angular/router/fesm5/router.js");
var __decorate = (undefined && undefined.__decorate) || function (decorators, target, key, desc) {
    var c = arguments.length, r = c < 3 ? target : desc === null ? desc = Object.getOwnPropertyDescriptor(target, key) : desc, d;
    if (typeof Reflect === "object" && typeof Reflect.decorate === "function") r = Reflect.decorate(decorators, target, key, desc);
    else for (var i = decorators.length - 1; i >= 0; i--) if (d = decorators[i]) r = (c < 3 ? d(r) : c > 3 ? d(target, key, r) : d(target, key)) || r;
    return c > 3 && r && Object.defineProperty(target, key, r), r;
};
var __metadata = (undefined && undefined.__metadata) || function (k, v) {
    if (typeof Reflect === "object" && typeof Reflect.metadata === "function") return Reflect.metadata(k, v);
};





var CompaniesComponent = /** @class */ (function () {
    function CompaniesComponent(httpClient, router) {
        this.httpClient = httpClient;
        this.router = router;
        this.title = 'odata-data-source-demo';
        this.baseUrl = 'http://dou-web-api.azurewebsites.net/';
        this.displayedColumns = ['Name', 'Score', 'SentimentAnalysisScore', 'ReviewsCount', 'actions'];
    }
    CompaniesComponent.prototype.ngOnInit = function () {
        var resourcePath = this.baseUrl + 'api/odata/companies';
        this.dataSource = new odata_data_source__WEBPACK_IMPORTED_MODULE_3__["ODataDataSource"](this.httpClient, resourcePath);
        this.dataSource.sort = this.sort;
        this.dataSource.paginator = this.paginator;
    };
    CompaniesComponent.prototype.onClick = function (row) {
        this.router.navigate(['/reviews'], { queryParams: { companyName: row.Name } });
    };
    CompaniesComponent.prototype.applyFilter = function (filterValue) {
        this.dataSource.filters = [{ getFilter: function () { return { name: { startswith: filterValue.toLowerCase() } }; } }];
    };
    __decorate([
        Object(_angular_core__WEBPACK_IMPORTED_MODULE_0__["ViewChild"])(_angular_material__WEBPACK_IMPORTED_MODULE_1__["MatSort"]),
        __metadata("design:type", _angular_material__WEBPACK_IMPORTED_MODULE_1__["MatSort"])
    ], CompaniesComponent.prototype, "sort", void 0);
    __decorate([
        Object(_angular_core__WEBPACK_IMPORTED_MODULE_0__["ViewChild"])(_angular_material__WEBPACK_IMPORTED_MODULE_1__["MatPaginator"]),
        __metadata("design:type", _angular_material__WEBPACK_IMPORTED_MODULE_1__["MatPaginator"])
    ], CompaniesComponent.prototype, "paginator", void 0);
    CompaniesComponent = __decorate([
        Object(_angular_core__WEBPACK_IMPORTED_MODULE_0__["Component"])({
            selector: 'app-companies',
            template: __webpack_require__(/*! ./companies.component.html */ "./src/app/companies/companies.component.html"),
            styles: [__webpack_require__(/*! ./companies.component.css */ "./src/app/companies/companies.component.css")]
        }),
        __metadata("design:paramtypes", [_angular_common_http__WEBPACK_IMPORTED_MODULE_2__["HttpClient"], _angular_router__WEBPACK_IMPORTED_MODULE_4__["Router"]])
    ], CompaniesComponent);
    return CompaniesComponent;
}());



/***/ }),

/***/ "./src/app/reviews/reviews.component.css":
/*!***********************************************!*\
  !*** ./src/app/reviews/reviews.component.css ***!
  \***********************************************/
/*! no static exports found */
/***/ (function(module, exports) {

module.exports = "table {\n  width: 100%;\n}\n\n.mat-form-field {\n  font-size: 14px;\n  width: 100%;\n}\n\ntd, th {\n  width: 25%;\n}\n"

/***/ }),

/***/ "./src/app/reviews/reviews.component.html":
/*!************************************************!*\
  !*** ./src/app/reviews/reviews.component.html ***!
  \************************************************/
/*! no static exports found */
/***/ (function(module, exports) {

module.exports = "<button mat-raised-button (click)=\"backClick()\" style=\"margin-bottom: 15px\">go back</button>\n<mat-form-field>\n  <input matInput (keyup)=\"applyFilter($event.target.value)\" placeholder=\"Search reviews by text\">\n</mat-form-field>\n<div class=\"mat-elevation-z2\">\n  <table mat-table [dataSource]=\"dataSource\" matSort>\n\n    <ng-container matColumnDef=\"CompanyName\">\n      <th mat-header-cell *matHeaderCellDef mat-sort-header> CompanyName </th>\n      <td mat-cell *matCellDef=\"let row\"> {{ row.CompanyName }} </td>\n    </ng-container>\n\n    <ng-container matColumnDef=\"Score\">\n      <th mat-header-cell *matHeaderCellDef mat-sort-header> Score </th>\n      <td mat-cell *matCellDef=\"let row\"> {{ row.Score }} </td>\n    </ng-container>\n\n    <ng-container matColumnDef=\"Text\">\n      <th mat-header-cell *matHeaderCellDef mat-sort-header> Text </th>\n      <td mat-cell *matCellDef=\"let row\"> {{ row.Text }} </td>\n    </ng-container>\n\n    <tr mat-header-row *matHeaderRowDef=\"displayedColumns\"></tr>\n    <tr mat-row *matRowDef=\"let row; columns: displayedColumns;\">\n    </tr>\n  </table>\n\n  <mat-paginator [pageSizeOptions]=\"[10, 25, 50]\"></mat-paginator>\n</div>"

/***/ }),

/***/ "./src/app/reviews/reviews.component.ts":
/*!**********************************************!*\
  !*** ./src/app/reviews/reviews.component.ts ***!
  \**********************************************/
/*! exports provided: ReviewsComponent */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "ReviewsComponent", function() { return ReviewsComponent; });
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! @angular/core */ "./node_modules/@angular/core/fesm5/core.js");
/* harmony import */ var _angular_material__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/material */ "./node_modules/@angular/material/esm5/material.es5.js");
/* harmony import */ var _angular_common_http__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! @angular/common/http */ "./node_modules/@angular/common/fesm5/http.js");
/* harmony import */ var odata_data_source__WEBPACK_IMPORTED_MODULE_3__ = __webpack_require__(/*! odata-data-source */ "./node_modules/odata-data-source/fesm5/odata-data-source.js");
/* harmony import */ var _angular_router__WEBPACK_IMPORTED_MODULE_4__ = __webpack_require__(/*! @angular/router */ "./node_modules/@angular/router/fesm5/router.js");
/* harmony import */ var _angular_common__WEBPACK_IMPORTED_MODULE_5__ = __webpack_require__(/*! @angular/common */ "./node_modules/@angular/common/fesm5/common.js");
var __decorate = (undefined && undefined.__decorate) || function (decorators, target, key, desc) {
    var c = arguments.length, r = c < 3 ? target : desc === null ? desc = Object.getOwnPropertyDescriptor(target, key) : desc, d;
    if (typeof Reflect === "object" && typeof Reflect.decorate === "function") r = Reflect.decorate(decorators, target, key, desc);
    else for (var i = decorators.length - 1; i >= 0; i--) if (d = decorators[i]) r = (c < 3 ? d(r) : c > 3 ? d(target, key, r) : d(target, key)) || r;
    return c > 3 && r && Object.defineProperty(target, key, r), r;
};
var __metadata = (undefined && undefined.__metadata) || function (k, v) {
    if (typeof Reflect === "object" && typeof Reflect.metadata === "function") return Reflect.metadata(k, v);
};






var ReviewsComponent = /** @class */ (function () {
    function ReviewsComponent(httpClient, route, _location) {
        this.httpClient = httpClient;
        this.route = route;
        this._location = _location;
        this.title = 'odata-data-source-demo';
        this.baseUrl = 'http://dou-web-api.azurewebsites.net/';
        this.displayedColumns = ['CompanyName', 'Score', 'Text'];
    }
    ReviewsComponent.prototype.ngOnInit = function () {
        var companyName = this.route.snapshot.queryParamMap.get('companyName');
        var resourcePath = this.baseUrl + "api/odata/reviews";
        this.dataSource = new odata_data_source__WEBPACK_IMPORTED_MODULE_3__["ODataDataSource"](this.httpClient, resourcePath);
        this.dataSource.sort = this.sort;
        this.dataSource.paginator = this.paginator;
        this.dataSource.filters = [{ getFilter: function () { return { CompanyName: companyName }; } }];
    };
    ReviewsComponent.prototype.backClick = function () {
        this._location.back();
    };
    ReviewsComponent.prototype.applyFilter = function (filterValue) {
        this.dataSource.filters = [{ getFilter: function () { return { text: { contains: filterValue } }; } }];
    };
    __decorate([
        Object(_angular_core__WEBPACK_IMPORTED_MODULE_0__["ViewChild"])(_angular_material__WEBPACK_IMPORTED_MODULE_1__["MatSort"]),
        __metadata("design:type", _angular_material__WEBPACK_IMPORTED_MODULE_1__["MatSort"])
    ], ReviewsComponent.prototype, "sort", void 0);
    __decorate([
        Object(_angular_core__WEBPACK_IMPORTED_MODULE_0__["ViewChild"])(_angular_material__WEBPACK_IMPORTED_MODULE_1__["MatPaginator"]),
        __metadata("design:type", _angular_material__WEBPACK_IMPORTED_MODULE_1__["MatPaginator"])
    ], ReviewsComponent.prototype, "paginator", void 0);
    ReviewsComponent = __decorate([
        Object(_angular_core__WEBPACK_IMPORTED_MODULE_0__["Component"])({
            selector: 'app-reviews',
            template: __webpack_require__(/*! ./reviews.component.html */ "./src/app/reviews/reviews.component.html"),
            styles: [__webpack_require__(/*! ./reviews.component.css */ "./src/app/reviews/reviews.component.css")]
        }),
        __metadata("design:paramtypes", [_angular_common_http__WEBPACK_IMPORTED_MODULE_2__["HttpClient"], _angular_router__WEBPACK_IMPORTED_MODULE_4__["ActivatedRoute"], _angular_common__WEBPACK_IMPORTED_MODULE_5__["Location"]])
    ], ReviewsComponent);
    return ReviewsComponent;
}());



/***/ }),

/***/ "./src/environments/environment.ts":
/*!*****************************************!*\
  !*** ./src/environments/environment.ts ***!
  \*****************************************/
/*! exports provided: environment */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "environment", function() { return environment; });
// This file can be replaced during build by using the `fileReplacements` array.
// `ng build --prod` replaces `environment.ts` with `environment.prod.ts`.
// The list of file replacements can be found in `angular.json`.
var environment = {
    production: false
};
/*
 * For easier debugging in development mode, you can import the following file
 * to ignore zone related error stack frames such as `zone.run`, `zoneDelegate.invokeTask`.
 *
 * This import should be commented out in production mode because it will have a negative impact
 * on performance if an error is thrown.
 */
// import 'zone.js/dist/zone-error';  // Included with Angular CLI.


/***/ }),

/***/ "./src/main.ts":
/*!*********************!*\
  !*** ./src/main.ts ***!
  \*********************/
/*! no exports provided */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! @angular/core */ "./node_modules/@angular/core/fesm5/core.js");
/* harmony import */ var _angular_platform_browser_dynamic__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/platform-browser-dynamic */ "./node_modules/@angular/platform-browser-dynamic/fesm5/platform-browser-dynamic.js");
/* harmony import */ var _app_app_module__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! ./app/app.module */ "./src/app/app.module.ts");
/* harmony import */ var _environments_environment__WEBPACK_IMPORTED_MODULE_3__ = __webpack_require__(/*! ./environments/environment */ "./src/environments/environment.ts");




if (_environments_environment__WEBPACK_IMPORTED_MODULE_3__["environment"].production) {
    Object(_angular_core__WEBPACK_IMPORTED_MODULE_0__["enableProdMode"])();
}
Object(_angular_platform_browser_dynamic__WEBPACK_IMPORTED_MODULE_1__["platformBrowserDynamic"])().bootstrapModule(_app_app_module__WEBPACK_IMPORTED_MODULE_2__["AppModule"])
    .catch(function (err) { return console.error(err); });


/***/ }),

/***/ 0:
/*!***************************!*\
  !*** multi ./src/main.ts ***!
  \***************************/
/*! no static exports found */
/***/ (function(module, exports, __webpack_require__) {

module.exports = __webpack_require__(/*! /Users/sashagolovach/Documents/DOU Companies/DOU Companies/Dou-Companies-Front/src/main.ts */"./src/main.ts");


/***/ })

},[[0,"runtime","vendor"]]]);
//# sourceMappingURL=main.js.map