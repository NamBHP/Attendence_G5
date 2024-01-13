package com.lowshade.attendance.controller;


import javax.swing.text.html.HTML;
import org.springframework.stereotype.Controller;
import org.springframework.ui.Model;
import org.springframework.web.bind.annotation.GetMapping;

/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */

/**
 *
 * @author Admin
 */
@Controller
public class SimpleController  {
    
   @GetMapping("/")
    public String home(Model model) {
        // Add any model attributes if needed
        model.addAttribute("message", "Nya hallo!");
        model.addAttribute("greeting", "Hope you have a good day sir!");
        return "simpleWeb"; // This corresponds to the view name (index.html)
    }
}
