(function () {
    'use strict';

    angular.module('Orders')
        .service('orderResources', ['appSettings', '$resource',
            function (appSettings, $resource) {

                this.Orders = $resource(appSettings.serverPath + '/api/orders');
                
                this.OrdersWithProducts = $resource(appSettings.serverPath + '/api/orders/getOrdersWithProducts/Id/:id');
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