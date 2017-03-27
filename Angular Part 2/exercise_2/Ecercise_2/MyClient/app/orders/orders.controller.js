(function () {
    'use strict';

    angular.module('Orders')
        .service('orderResources', ['appSettings', '$resource',
            function (appSettings, $resource) {

                this.Orders = $resource(appSettings.serverPath + '/api/orders');
                
                this.OrdersWithProducts = $resource(appSettings.serverPath + '/api/orders/getOrdersWithProducts/Id/:id');
            }
        ])

        .service('customerResources', ['appSettings', '$resource',
            function (appSettings, $resource) {

                this.Customers = $resource(appSettings.serverPath + '/api/customers');

            }
        ])

        .controller('EditOrdersController', ['customerResources',
            function (customerResources) {
                let vm = this;

                vm.customers = [];
                vm.selectedCustomer = 0;
                vm.customer = undefined;

                customerResources.Customers.query((data) => {
                    vm.customers = data;
                    vm.selectedCustomer = 0;
                    vm.customer = vm.customers[0];
                });

                vm.changeCustomer = () => {
                    vm.customer = vm.customers[vm.selectedCustomer];
                };
            }
        ])

        .controller('OrderController', ['orderResources',
            function (orderResources) {
                let vm = this;
                vm.lines = [];
                vm.orders = [];
                vm.productOrderLines = [];
                vm.something = 'BABOOM';

                orderResources.Orders.query((data) => {
                    console.log('DATA', data);
                    vm.orders = data;
                });

                vm.getOrdersWithProducts = function (orderId) {
                    orderResources.OrdersWithProducts.query({
                        id: orderId
                    }, function (data) {
                        vm.productOrderLines = data;
                    });
                };

                vm.showOrderLines = function (orderId) {
                    vm.lines = [];
                
                    vm.orders
                        .map(order => {
                            if (order.id == orderId) {
                                order.orderLines
                                    .map(line => {
                                        vm.lines.push(line);
                                    });
                                console.debug(vm.lines);
                            }
                        });
                };
            }
        ]);

}());