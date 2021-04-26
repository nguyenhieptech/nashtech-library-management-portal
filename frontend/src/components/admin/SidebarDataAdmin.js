import { FaCartPlus, FaEnvelopeOpenText } from "react-icons/fa";
import { AiFillHome } from "react-icons/ai";
import { IoIosPaper, IoMdPeople, IoMdHelpCircle } from "react-icons/io";

export const SidebarData = [
  {
    title: "Home",
    path: "/",
    icon: <AiFillHome />,
    cName: "nav-text",
  },
  {
    title: "Login",
    path: "/login",
    icon: <IoIosPaper />,
    cName: "nav-text",
  },
  {
    title: "Products",
    path: "/products",
    icon: <FaCartPlus />,
    cName: "nav-text",
  },
  {
    title: "Team",
    path: "/team",
    icon: <IoMdPeople />,
    cName: "nav-text",
  },
  {
    title: "Messages",
    path: "/messages",
    icon: <FaEnvelopeOpenText />,
    cName: "nav-text",
  },
  {
    title: "Support",
    path: "/support",
    icon: <IoMdHelpCircle />,
    cName: "nav-text",
  },
];
