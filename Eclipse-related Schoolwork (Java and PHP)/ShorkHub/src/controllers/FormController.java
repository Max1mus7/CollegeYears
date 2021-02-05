package controllers;

import javax.faces.context.FacesContext;

import beans.User;

import javax.faces.bean.ManagedBean;
import javax.faces.bean.ViewScoped;

@ManagedBean
@ViewScoped
public class FormController 
{

	
	public String onLoginSubmit(User user)
		{

			FacesContext.getCurrentInstance().getExternalContext().getRequestMap().put("user", user);
			return "LoginResponse.xhtml";
		}
    public String onRegistrationSubmit(User user)
	{

		FacesContext.getCurrentInstance().getExternalContext().getRequestMap().put("user", user);
		return "RegistrationResponse.xhtml";
	}
}
