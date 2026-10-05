import { ModRegistrar, ModuleRegistry } from "cs2/modding";
import { initialize } from "vanilla/Components";

const register: ModRegistrar = (moduleRegistry: ModuleRegistry) => {
    initialize(moduleRegistry);
};

export default register;
