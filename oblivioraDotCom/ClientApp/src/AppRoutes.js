import { Randomizer } from "./components/Randomizer";
import { Home } from "./components/Home";

const AppRoutes = [
  {
    index: true,
    element: <Home />
  },
  {
    path: '/feRandom',
    element: <Randomizer />
  }
];

export default AppRoutes;
