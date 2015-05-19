//var serviceURL = 'http://localhost:2/api/';
var serviceURL = 'http://vs13sql12ba4.cloudapp.net/api/';

pos.service('posService', function ($http) {
    //Get All Customer
    this.getCustomer = function () {
        return $http.get(serviceURL + "Customer");
    }

    //Create new record
    //this.post = function (Employee) {
    //    var request = $http({
    //        method: "post",
    //        url: "/api/EmployeesAPI",
    //        data: Employee
    //    });
    //    return request;
    //}
    //Get Single Records
    this.get = function () {
        return $http.get("http://vs13sql12ba4.cloudapp.net/api/OCRDs");
    }

    ////Get All Employees
    //this.getEmployees = function () {
    //    return $http.get("/api/EmployeesAPI");
    //}


    ////Update the Record
    //this.put = function (EmpNo, Employee) {
    //    var request = $http({
    //        method: "put",
    //        url: "/api/EmployeesAPI/" + EmpNo,
    //        data: Employee
    //    });
    //    return request;
    //}
    ////Delete the Record
    //this.delete = function (EmpNo) {
    //    var request = $http({
    //        method: "delete",
    //        url: "/api/EmployeesAPI/" + EmpNo
    //    });
    //    return request;
    //}
});

chart.service('chartService', function ($http) {
    //Get All Customer
    this.getSalesBarChart = function () {
        return $http.get(serviceURL + "SalesBarChart");
    }
});