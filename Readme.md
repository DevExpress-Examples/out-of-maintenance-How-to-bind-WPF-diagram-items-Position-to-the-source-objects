<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/397543311/21.1.5%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T1022650)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->

# WPF Diagram Control - Bind Item Positions to Source Objects

This example demonstrates how to bind positions of diagram items to source properties (in two-way mode) when you generate these items from a source collection.

![image](https://github.com/DevExpress-Examples/wpf-diagram-bind-item-positions-to-source-objects/assets/65009440/e6834f83-f489-4c2b-b197-b9fb30335f27)

Create a `DiagramBinding` object, specify target and source properties and binding mode, and assign the object to the [DiagramItem.Bindings](https://docs.devexpress.com/WPF/DevExpress.Xpf.Diagram.DiagramItem.Bindings) property:

```xaml
<dxdiag:DiagramShape.Bindings>
    <dxdiag:DiagramBinding PropertyName="Position"
                           Expression="Position"
                           Mode="TwoWay"/>
</dxdiag:DiagramShape.Bindings>
```

Handle the [DiagramDataBindingBehaviorBase.CustomLayoutItems](https://docs.devexpress.com/WPF/DevExpress.Xpf.Diagram.DiagramDataBindingBehaviorBase.CustomLayoutItems) event to disable the default layout algorithm.

## Files to Review

* [MainWindow.xaml](./CS/dxSample/MainWindow.xaml)
* [MainWindow.xaml.cs](./CS/dxSample/MainWindow.xaml.cs) (VB: [MainWindow.xaml.vb](./VB/dxSample/MainWindow.xaml.vb))
* [ViewModel.cs](./CS/dxSample/ViewModel.cs) (VB: [ViewModel.vb](./VB/dxSample/ViewModel.vb))

## Documentation

* [Generate Diagrams from a Data Source](https://docs.devexpress.com/WPF/118578/controls-and-libraries/diagram-control/data-binding/generating-diagrams-from-a-data-source)
* [DiagramItem.Bindings](https://docs.devexpress.com/WPF/DevExpress.Xpf.Diagram.DiagramItem.Bindings)
* [DiagramItem.Position](https://docs.devexpress.com/WPF/DevExpress.Xpf.Diagram.DiagramItem.Position)
* [DiagramDataBindingBehaviorBase.CustomLayoutItems](https://docs.devexpress.com/WPF/DevExpress.Xpf.Diagram.DiagramDataBindingBehaviorBase.CustomLayoutItems)

## More Examples

* [WPF Diagram - Use the DiagramDataBindingBehavior to Generate a Diagram from a Collection](https://github.com/DevExpress-Examples/wpf-diagram-use-diagramdatabindingbehavior-to-generate-diagram-from-collection)
* [WPF Diagram Control - Generate Diagrams with Grouped Items](https://github.com/DevExpress-Examples/wpf-generate-diagram-with-grouped-items)
