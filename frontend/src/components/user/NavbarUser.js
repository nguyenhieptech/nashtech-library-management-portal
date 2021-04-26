import { useState } from "react";
import { FaBars } from "react-icons/fa";
import { AiOutlineClose } from "react-icons/ai";
import { Link } from "react-router-dom";
import { SidebarData } from "./SidebarDataAdmin";
import { IconContext } from "react-icons";
import styled from "@emotion/styled";
import "../Navbar.css";

const StyledNavbar = styled("div")`
  background-color: var(--navbar-color);
  width: 250px;
  height: 100vh;
  display: flex;
  justify-content: center;
  position: fixed;
  top: 0;
  left: ${(props) => (props.collapse ? "0" : "-100%")};
  transition: ${(props) => (props.collapse ? "350ms" : "850ms")};
`;

function NavbarUser() {
  const [sidebar, setSidebar] = useState(false);

  const showSidebar = () => setSidebar(!sidebar);

  return (
    <>
      <IconContext.Provider value={{ color: "#fff" }}>
        <div className='navbar'>
          <Link to='#' className='menu-bars'>
            <FaBars onClick={showSidebar} />
          </Link>
        </div>
        <StyledNavbar collapse={sidebar}>
          <ul className='nav-menu-items' onClick={showSidebar}>
            <li className='navbar-toggle'>
              <Link to='#' className='menu-bars'>
                <AiOutlineClose />
              </Link>
            </li>
            {SidebarData.map((item, index) => {
              return (
                <li key={index} className={item.cName}>
                  <Link to={item.path}>
                    {item.icon}
                    <span>{item.title}</span>
                  </Link>
                </li>
              );
            })}
          </ul>
        </StyledNavbar>
      </IconContext.Provider>
    </>
  );
}

export default NavbarUser;
