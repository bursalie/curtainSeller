(function () {
    angular.module('app').controller('app.views.inventory.createModal', [
        '$scope', '$uibModalInstance', 'abp.services.app.inventory',
        function ($scope, $uibModalInstance, inventoryService) {
            var vm = this;

            vm.item = {};
 
            vm.save = function () {

                inventoryService.create(vm.item)
                    .then(function () {
                        abp.notify.info(App.localize('SavedSuccessfully'));
                        $uibModalInstance.close();
                    });
            };

            vm.cancel = function () {
                $uibModalInstance.dismiss({});
            };
        }
    ]);
})();