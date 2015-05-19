pos.controller('posController', function ($scope, posService, $sce,$q) {
    //pos.controller('posController', ['$scope', function ($scope, $sce, $q, posService) {
    var promiseGet = posService.getCustomer(); //The MEthod Call from service
    promiseGet.then(function (pl) {
        $scope.customer = pl.data;
        $("#customerName").removeAttr("disabled");
        $("#customerCode").removeAttr("disabled");
    },
          function (errorPl) {
              //$log.error('failure loading Employee', errorPl);
          });
    $scope.CustomerName = "";
    $scope.CustomerCode = "";
    function suggest_users(term) {
        var q = term.toLowerCase().trim(),
                results = [];
        for (var i = 0; i < $scope.customer.length; i++) {
            var cust = $scope.customer[i];
            if (cust.CustomerName.toLowerCase().indexOf(q) !== -1 ||
                cust.CustomerName.toLowerCase().indexOf(q) !== -1)
                results.push({
                    value: cust.CustomerName,
                    // Pass the object as well. Can be any property name.
                    obj: cust,
                    //label: cust.CustomerName + " --  " + cust.CustomerCode
                    label: $sce.trustAsHtml(
           '<div class="row">' +
           ' <div class="col-xs-5">' +
           '  <i class="fa fa-user"></i>' +
           '  <strong>' + highlight(cust.CustomerName, term) + '</strong>' +
           ' </div>' +
           ' <div class="col-xs-7 text-right text-muted">' +
           '  <small>' + cust.CustomerCode + '</small>' +
           ' </div>' +          
           '</div>'
         )
                });
        }
        return results;
    };

    function suggest_customer_code(term) {
        var q = term.toLowerCase().trim(),
                results = [];
        for (var i = 0; i < $scope.customer.length; i++) {
            var cust = $scope.customer[i];
            if (cust.CustomerName.toLowerCase().indexOf(q) !== -1 ||
                cust.CustomerName.toLowerCase().indexOf(q) !== -1)
                results.push({
                    value: cust.CustomerCode,
                    // Pass the object as well. Can be any property name.
                    obj: cust,
                    //label: cust.CustomerName + " --  " + cust.CustomerCode
                    label: $sce.trustAsHtml(
           '<div class="row">' +
           ' <div class="col-xs-5">' +
           '  <i class="fa fa-user"></i>' +
           '  <strong>' + highlight(cust.CustomerCode, term) + '</strong>' +
           ' </div>' +
           ' <div class="col-xs-7 text-right text-muted">' +
           '  <small>' + cust.CustomerName + '</small>' +
           ' </div>' +
           '</div>'
         )
                });
        }
        return results;
    };

    $scope.ac_options_users = {
        suggest: suggest_users,
        on_select: function (selected) {
            update_binding(selected);
        }
    };

    $scope.ac_options_customer_code = {
        suggest: suggest_customer_code,
        on_select: function (selected) {
            update_binding(selected);
        }
    };

    function update_binding(selected)
    {
        $('#customerName').val(selected.obj.CustomerName);
        $('#customerCode').val(selected.obj.CustomerCode);
            //$scope.$apply(function () {
            //    $scope.CustomerName = selected.obj.CustomerName;
            //    $scope.CustomerCode = selected.obj.CustomerCode;
            //});

    }
    //}]);
});

chart.controller('chartController', function ($scope, chartService) {
    var chartData = chartService.getSalesBarChart();
    chartData.then(function (pl) {
        //BuildSalesBarChart(pl.data);
        $scope.BuildSalesBarChart(pl.data);
        },
        function (errorPl) {
            //$log.error('failure loading Employee', errorPl);
        });
});