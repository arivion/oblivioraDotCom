import { EngageRandomizer } from "./components/EngageRandomizer";
import { Home } from "./components/Home";

const AppRoutes = [
  {
    index: true,
    element: <Home />
  },
  {
    path: '/engageRandom',
    element: <EngageRandomizer />
  }
];

export default AppRoutes;
