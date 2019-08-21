import { Component, OnInit, ViewChild } from '@angular/core';
import { MatSort, MatPaginator } from '@angular/material';
import { HttpClient } from '@angular/common/http';
import { ODataDataSource } from 'odata-data-source';
import { ActivatedRoute } from '@angular/router';
import { Location } from '@angular/common';
import { ODataFilter } from 'odata-data-source';

@Component({
  selector: 'app-reviews',
  templateUrl: './reviews.component.html',
  styleUrls: ['./reviews.component.css']
})
export class ReviewsComponent implements OnInit {
  @ViewChild(MatSort) sort: MatSort;
  @ViewChild(MatPaginator) paginator: MatPaginator;

  title = 'odata-data-source-demo';
  baseUrl = 'https://dou-web-api.azurewebsites.net/';

  displayedColumns: string[] = ['CompanyName', 'Score', 'Text'];

  dataSource: ODataDataSource;

  constructor(private readonly httpClient: HttpClient, private route: ActivatedRoute, private _location: Location) { }

  ngOnInit() {
    let companyName = this.route.snapshot.queryParamMap.get('companyName');
    let resourcePath = this.baseUrl + `api/odata/reviews`;

    this.dataSource = new ODataDataSource(this.httpClient, resourcePath);
    this.dataSource.sort = this.sort;
    this.dataSource.paginator = this.paginator;
    this.dataSource.filters = [{ getFilter: function () { return { CompanyName: companyName } } }];
  }

  backClick() {
    this._location.back();
  }

  applyFilter(filterValue: string) {
    this.dataSource.filters = [{ getFilter: function () { return { text: { contains: filterValue } } } }];
  }
}
