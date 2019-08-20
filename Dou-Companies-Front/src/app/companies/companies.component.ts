import { Component, OnInit, ViewChild } from '@angular/core';
import { MatSort, MatPaginator } from '@angular/material';
import { HttpClient } from '@angular/common/http';
import { ODataDataSource } from 'odata-data-source';
import { Router } from "@angular/router"

@Component({
  selector: 'app-companies',
  templateUrl: './companies.component.html',
  styleUrls: ['./companies.component.css']
})
export class CompaniesComponent implements OnInit {
  @ViewChild(MatSort) sort: MatSort;
  @ViewChild(MatPaginator) paginator: MatPaginator;

  title = 'odata-data-source-demo';

  displayedColumns: string[] = ['Name', 'Score', 'SentimentAnalysisScore', 'ReviewsCount', 'actions'];

  dataSource: ODataDataSource;

  constructor(private readonly httpClient: HttpClient, private router: Router) { }

  ngOnInit() {
    const resourcePath = 'api/odata/companies';
    this.dataSource = new ODataDataSource(this.httpClient, resourcePath);
    this.dataSource.sort = this.sort;
    this.dataSource.paginator = this.paginator;
  }

  onClick(row) {
    this.router.navigate(['/reviews'], { queryParams: { companyName: row.Name } });
  }

  applyFilter(filterValue: string) {
    this.dataSource.filters = [{ getFilter: function () { return { name: { startswith: filterValue.toLowerCase() } } } }];
  }
}
