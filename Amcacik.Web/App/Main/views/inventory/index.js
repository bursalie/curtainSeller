(function () {
    angular.module('app').controller('app.views.inventory.index', [
        '$scope', '$uibModal', 'abp.services.app.inventory',
        function ($scope, $uibModal, inventoryService) {
            var vm = this;

            vm.items = [];

            function getItems() {
                inventoryService.getAll({}).then(function (result) {
                    vm.items = result.data.items;
                });
            }

            vm.openInventoryCreationModal = function () {
                var modalInstance = $uibModal.open({
                    templateUrl: '/App/Main/views/inventory/createModal.cshtml',
                    controller: 'app.views.inventory.createModal as vm',
                    backdrop: 'static'
                });

                modalInstance.rendered.then(function () {
                    $.AdminBSB.input.activate();
                });

                modalInstance.result.then(function () {
                    getItems();
                });
            };

            vm.openInventoryEditModal = function (item) {
                var modalInstance = $uibModal.open({
                    templateUrl: '/App/Main/views/inventory/editModal.cshtml',
                    controller: 'app.views.inventory.editModal as vm',
                    backdrop: 'static',
                    resolve: {
                        id: function () {
                            return item.id;
                        }
                    }
                });

                modalInstance.rendered.then(function () {
                    $.AdminBSB.input.activate();
                });

                modalInstance.result.then(function () {
                    getItems();
                });
            };

            vm.delete = function (item) {
                abp.message.confirm(
                    "Delete item '" + item.name + "'?",
                    function (result) {
                        if (result) {
                            inventoryService.delete({ id: item.id })
                                .then(function () {
                                    abp.notify.info("Deleted item: " + item.name);
                                    getItems();
                                });
                        }
                    });
            }

            vm.refresh = function () {
                getItems();
            };

            getItems();
        }
    ]);
})();