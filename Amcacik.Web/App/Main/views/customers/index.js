(function () {
    angular.module('app').controller('app.views.customers.index', [
        '$scope', '$uibModal', 'abp.services.app.customer',
        function ($scope, $uibModal, customerService) {
            var vm = this;

            vm.customers = [];

            function getCustomers() {
                customerService.getAll({}).then(function (result) {
                    vm.customers = result.data.items;
                });
            }

            vm.openCustomerCreationModal = function () {
                var modalInstance = $uibModal.open({
                    templateUrl: '/App/Main/views/customers/createModal.cshtml',
                    controller: 'app.views.customers.createModal as vm',
                    backdrop: 'static'
                });

                modalInstance.rendered.then(function () {
                    $.AdminBSB.input.activate();
                });

                modalInstance.result.then(function () {
                    getCustomers();
                });
            };

            vm.openCustomerEditModal = function (customer) {
                var modalInstance = $uibModal.open({
                    templateUrl: '/App/Main/views/customers/editModal.cshtml',
                    controller: 'app.views.customers.editModal as vm',
                    backdrop: 'static',
                    resolve: {
                        id: function () {
                            return customer.id;
                        }
                    }
                });

                modalInstance.rendered.then(function () {
                    $.AdminBSB.input.activate();
                });

                modalInstance.result.then(function () {
                    getCustomers();
                });
            };

            vm.delete = function (customer) {
                abp.message.confirm(
                    "Delete customer '" + customer.name + "'?",
                    function (result) {
                        if (result) {
                            customerService.delete({ id: customer.id })
                                .then(function () {
                                    abp.notify.info("Deleted customer: " + customer.name);
                                    getCustomers();
                                });
                        }
                    });
            }

            vm.refresh = function () {
                getCustomers();
            };

            getCustomers();
        }
    ]);
})();