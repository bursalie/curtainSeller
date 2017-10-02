(function () {
    angular.module('app').controller('app.views.inventory.editModal', [
        '$scope', '$uibModalInstance', 'abp.services.app.inventory', 'id',
        function ($scope, $uibModalInstance, inventoryService, id) {
            var vm = this;

            vm.item = {};

            function init() {

                inventoryService.get({ id: id })
                    .then(function (result) {
                        vm.item = result.data;
                    });

            }

            vm.save = function () {
               
                inventoryService.update(vm.item)
                    .then(function () {
                        abp.notify.info(App.localize('SavedSuccessfully'));
                        $uibModalInstance.close();
                    });
            };

            vm.cancel = function () {
                $uibModalInstance.dismiss({});
            };

            init();
        }
    ]);
})();