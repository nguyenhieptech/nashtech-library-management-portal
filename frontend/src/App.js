import { BrowserRouter as Router, Switch, Route } from "react-router-dom";
import Home from "./pages/admin/Home";
import Login from "./pages/Login";

function App() {
  return (
    <>
      <Router>
        <Switch>
          <Route path='/' exact component={Home} />
          <Route path='/login' component={Login} />
        </Switch>
      </Router>
    </>
  );
}

export default App;
